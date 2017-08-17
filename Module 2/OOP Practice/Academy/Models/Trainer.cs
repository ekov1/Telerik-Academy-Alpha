using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Exceptions;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;
        private IList<string> technologies;

        public IList<string> Technologies
        {
            get { return this.technologies; }
            set { this.technologies = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public Trainer(string username, string technologies)
        {
            //username
            if (string.IsNullOrEmpty(username) || username.Length < 2 || username.Length > 17)
            {
                throw new ArgumentException(ExceptionMessages.Username);
            }
            this.username = username;

            //technologies
            this.technologies = technologies.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("* Trainer:");
            result.AppendLine($" - Username: {username}");
            result.Append($"Technologies: {string.Join("; ", technologies)}");

            return result.ToString();
        }
    }
}
