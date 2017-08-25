using System;
namespace Web.Models
{
    public class Ad
    {
        public Ad()
        {
        }

        public Ad(string linkUrl, string imageUrl, string content)
        {
            this.LinkUrl = linkUrl;
            this.ImageUrl = imageUrl;
            this.Content = content;
        }

        public string LinkUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
    }
}
