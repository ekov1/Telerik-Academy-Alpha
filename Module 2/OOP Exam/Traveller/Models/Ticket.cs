using System.Text;
using Traveller.Models.Contracts;

namespace Traveller.Models
{
    public class Ticket : ITicket
    {
        private IJourney journey;
        private decimal administrativeCosts;

        public IJourney Journey
        {
            get { return this.journey; }
        }

        public decimal AdministrativeCosts
        {
            get { return this.administrativeCosts; }
        }

        public decimal CalculatePrice()
        {
            return  AdministrativeCosts + Journey.CalculateTravelCosts();
        }

        public Ticket(IJourney journey, decimal administrativeCosts)
        {
            this.journey = journey;
            this.administrativeCosts = administrativeCosts;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Ticket ----");
            result.AppendLine($"Destination: {Journey.Destination}");
            result.Append($"Price: {CalculatePrice()}");

            return result.ToString();
        }
    }
}
