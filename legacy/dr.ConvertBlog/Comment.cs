using System;

namespace dr.TinyBlog
{
    public class Comment 
    {
        internal Comment() {}

        public Comment(string email, string author, string body)
        {
            Email = email;
            Body = body;
            Author = author;
            Created = DateTime.Now;
            Approved = true;
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Comment"/> is approved.
        /// </summary>
        /// <value><c>true</c> if approved; otherwise, <c>false</c>.</value>
        public bool Approved { get; set; }

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
        /// Created time
        /// </summary>
        public DateTime Created { get; set; }
    }
}