using System;
namespace Web.Models
{
    public class TopicFilter
    {
        public TopicFilter()
        {
        }

        public string SearchTerms { get; set; }
        public int Limit { get; set; }
    }
}
