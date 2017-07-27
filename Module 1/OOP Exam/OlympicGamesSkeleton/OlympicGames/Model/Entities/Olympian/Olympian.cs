using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Model.Entities
{
    public abstract class Olympian : IOlympian
    {
        private string firstName;
        private string lastName;
        private string country;

        public string FirstName
        {
            get
            {
                return this.firstName;                
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;                
            }
        }

        public string Country
        {
            get
            {
                return this.country;                
            }
        }

        public Olympian(string firstName, string lastName, string country)
        {
            firstName.ValidateMinAndMaxLength(2, 20);
            lastName.ValidateMinAndMaxLength(2, 20);
            country.ValidateMinAndMaxLength(3,25);

            this.firstName = firstName;
            this.lastName = lastName;
            this.country = country;
        }
    }
}
