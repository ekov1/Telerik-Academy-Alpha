using System;
using System.Collections.Generic;
using Traveller.Commands.Listing;
using Traveller.Core.Repository;

namespace Traveller.Commands.Creating
{
    public class ListVehiclesCommand : ListCommand
    {
        public ListVehiclesCommand(IDatabase database) : base(database) { }

        public override string Execute(IList<string> parameters)
        {
            var vehicles = Database.Vehicles;

            if (vehicles.Count == 0)
            {
                return "There are no registered vehicles.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicles);
        }
    }
}
