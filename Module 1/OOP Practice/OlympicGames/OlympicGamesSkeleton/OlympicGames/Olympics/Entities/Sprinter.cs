using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Entities
{
    public class Sprinter : Olympian, ISprinter
    {
        private IDictionary<string, double> personalRecords;

        public IDictionary<string, double> PersonalRecords
        {
            get { return this.personalRecords; }
        }

        public Sprinter(string firstName, string lastName, string country,
            IDictionary<string, double> personalRecords) : base(firstName, lastName, country)
        {
            this.personalRecords = personalRecords;
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine($"SPRINTER: {FirstName} {LastName} from {Country}");

            if (personalRecords.Count == 0)
            {
                output.AppendLine($"{GlobalConstants.NoPersonalRecordsSet}");
            }
            else
            {
                output.AppendLine($"{GlobalConstants.PersonalRecords}");
                foreach (var personalRecord in personalRecords)
                {
                    output.AppendLine($"{personalRecord.Key}m: {personalRecord.Value}s ");
                }
            }

            return output.ToString();
        }
    }
}
