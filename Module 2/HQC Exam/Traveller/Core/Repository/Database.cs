using System.Collections.Generic;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Repository
{
    public class Database : IDatabase
    {
        // no it's not a repository pattern (could not think of a better folder name)
        public IList<IVehicle> Vehicles { get; }
        public IList<IJourney> Journeys { get; }
        public IList<ITicket> Tickets { get; }
        public IList<string> ExecutionResult { get; }

        public Database()
        {
            this.Vehicles = new List<IVehicle>();
            this.Journeys = new List<IJourney>();
            this.Tickets = new List<ITicket>();
            this.ExecutionResult = new List<string>();
        }
    }
}
