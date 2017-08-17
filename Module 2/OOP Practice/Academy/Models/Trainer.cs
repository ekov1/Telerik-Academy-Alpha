using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

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

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public Trainer(string username, string technologies)
        {
            this.Username = username;

            this.Technologies = new List<string>();
        }
    }
}
