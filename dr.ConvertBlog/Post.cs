using System;
using System.Collections.Generic;

namespace dr.TinyBlog
{
    /// <summary>
    /// A post.
    /// </summary>
    public class Post
    {
        internal Post() {}
        
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the URL.
        /// </summary>
        /// <value>The name of the URL.</value>
        public string UrlName { get; set; }

        /// <summary>
        /// Gets the body HTML.
        /// </summary>
        /// <value>The body HTML.</value>
        public string BodyHtml { get; set; }
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the name of the author
        /// </summary>
        public string Author { get; set; }
        
        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        /// <value>The published.</value>
        public DateTime? Published { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is published.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is published; otherwise, <c>false</c>.
        /// </value>
        public bool IsPublished
        {
            get { return Published != null && Published < DateTime.Now; }
        }

        /// <summary>
        /// Gets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public ICollection<Comment> Comments { get; private set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public IList<string> Tags { get; private set; }
    }
}