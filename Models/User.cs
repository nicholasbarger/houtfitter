using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class User
    {
        public User()
        {
        }

        public User(Guid id)
        {
            this.Id = id;
        }

        public User(string emailAddress)
        {
            this.Id = Guid.NewGuid();
            this.EmailAddress = emailAddress;
        }

        public User(string emailAddress, string name) : this(emailAddress)
        {
            this.Name = Name;
        }

        public Guid Id { get; set; }
        public List<Topic> Contributions { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string[] Interests { get; set; }
    }
}
