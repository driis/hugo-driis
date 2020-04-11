using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using dr.TinyBlog;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace dr.ConvertBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Expecting two arguments:");
                Console.WriteLine("<input.json> <outputdir>");
                return;
            }

            var json = JsonConvert.DeserializeObject<dynamic>(System.IO.File.ReadAllText(args[0]));
            JArray posts = json.Results;
            foreach (var post in posts.Select(t => t.ToObject<Post>()).OrderBy(x => x.Published))
            {
                WritePostMarkdown(post, args[1]);
            }
        }

        private static void WritePostMarkdown(Post post, string directory)
        {
            bool isHtml = post.Body == post.BodyHtml;
            string extension = isHtml ? "html" : "md";
            string content = isHtml ? post.BodyHtml : post.Body;
            string path = Path.Combine(directory, $"{post.UrlName}.{extension}");
            using StreamWriter w = new StreamWriter(path, append:false, Encoding.UTF8);
            w.Write("+++");
            w.WriteLine("draft = false");
            w.WriteLine($"date = {post.Published:O}");
            w.WriteLine($"title = \"{post.Title}\"");
            w.WriteLine($"slug = \"{post.UrlName}\"");
            w.WriteLine("+++");
            w.WriteLine(content);
        }
    }
}
