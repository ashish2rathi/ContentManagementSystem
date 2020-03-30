using System;

namespace CMS.SDK
{
    public class Blog
    {
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string MetaTags { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public BlogCategory Category { get; set; }
    }
}