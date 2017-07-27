using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands.Abstracts
{
    public abstract class CreateCommand : Command
    {
        private string firstName;
        private string lastName;
        private string country;

        public string FristName
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

        protected CreateCommand(IList<string> commandParameters) : base(commandParameters)
        {
            commandParameters.ValidateIfNull();
            if (commandParameters.Count < 3)
            {
                throw new ArgumentException($"{GlobalConstants.ParametersCountInvalid}");
            }

            var firstName = commandParameters[0].Trim();
            firstName.ValidateFirstName();
            firstName.ValidateIfNull();
            this.firstName = firstName;

            var lastName = commandParameters[1].Trim();
            lastName.ValidatLastName();
            lastName.ValidateIfNull();
            this.lastName = lastName;

            var country = commandParameters[2].Trim();
            country.ValidatCountry();
            country.ValidateIfNull();
            this.country = country;
        }
    }
}
