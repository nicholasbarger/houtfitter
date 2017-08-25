using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Web.Models;

namespace Web.Logic
{
    public class TopicLogic
    {
        public TopicLogic()
        {
		}

        public void Create(Topic topic)
        {
			// todo
			// FakeData.Topics.Add(topic);
		}

        public Topic GetById(Guid id)
        {
            return FakeData.Topics.Where(a => a.Id == id).FirstOrDefault();
        }

        public Topic GetByName(string name)
        {
            return FakeData.Topics.Where(a => a.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }

		public List<Topic> GetTopics(TopicFilter filter = null)
		{
			if (filter != null)
			{
				IQueryable<Topic> query = FakeData.Topics;

				if (!string.IsNullOrEmpty(filter.SearchTerms))
				{
					query = query.Where(a => a.Name.ToLower().Contains(filter.SearchTerms));
				}

				if (filter.Limit > 0)
				{
					query.Take(filter.Limit);
				}

				return query.ToList();
			}
			else
			{
				return FakeData.Topics.ToList();
			}
		}

        public List<Topic> GetTopicInterests()
        {
            // todo
            return FakeData.Topics.Where(a => a.Name.ToLower() == "fishing").ToList();
        }

        public void Update(Topic topic)
        {
            // todo
        }

        public void UpVote(Guid topicId, Guid userId)
        {
            // todo
        }

        public void DownVote(Guid topicId, Guid userId)
        {
            // todo
        }

        public void ValidateTopic(Topic topic)
        {
            // todo
        }
    }
}
