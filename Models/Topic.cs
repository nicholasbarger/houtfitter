using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Topic
    {
        public Topic()
		{
			this.Ads = new List<Ad>();
            this.Tags = new List<string>();
            this.SubTopics = new List<Topic>();
            this.Videos = new List<Video>();
        }

        public Topic(Guid id) : this()
        {
            this.Id = id;
        }

        public Topic(string name, string content, User originalAuthor, List<string> tags = null, string imageUrl = null, List<Video> videos = null) : this()
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Content = content;
            this.OriginalAuthor = originalAuthor;
			this.ImageUrl = imageUrl;

			if(tags != null)
            {
                this.Tags = tags;    
            }

            if(videos != null)
            {
                this.Videos = videos;
            }
        }

        public Guid Id { get; set; }
        public List<Ad> Ads { get; set; }
        public string Content { get; set; }
        public User OriginalAuthor { get; set; }
        public string Name { get; set; }
        public List<string> Tags { get; set; }
        public List<Video> Videos { get; set; }
        public DateTime Created { get; set; }
        public int Rating { get; set; }
        public List<Topic> SubTopics { get; set; }
        public string ImageUrl { get; set; }
    }
}
