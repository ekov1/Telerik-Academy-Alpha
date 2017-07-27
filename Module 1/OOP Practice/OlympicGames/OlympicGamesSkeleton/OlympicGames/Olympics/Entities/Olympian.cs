using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Olympics.Entities
{
    public abstract class Olympian : IOlympian
    {
        private string firstName;
        private string lastName;
        private string country;

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public string Country
        {
            get { return this.country; }
        }

        protected Olympian(string firstName, string lastName, string country)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.country = country;
        }

        public abstract override string ToString();
    }
}
