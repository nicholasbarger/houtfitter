using System;
namespace Web.Models
{
    public class Video
    {
        public Video()
        {
        }

        public string Url { get; set; }
        public VideoSource Source { get; set; }
        public DateTime Added { get; set; }
        public bool IsShownInMainContent { get; set; }
        public int RelevanceScore { get; set; }
        public int Sequence { get; set; }

		public string EmbedUrl
		{
			get
			{
                var src = "";

				switch (this.Source)
				{
                    case VideoSource.Vimeo:
                        src = "";
                        break;

                    case VideoSource.Youtube:
                    default:
                        src = string.Format("<iframe width=\"560\" height=\"315\" src=\"{0}\" frameborder=\"0\" allowfullscreen></iframe>", this.Url.Replace("watch?v=", "embed/"));
                        break;
				}

                return src;
			}
		}
    }

    public enum VideoSource
    {
        Youtube = 1,
        Vimeo = 2
    }
}
