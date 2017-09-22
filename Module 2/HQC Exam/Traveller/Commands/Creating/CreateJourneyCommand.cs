using System;
using System.Collections.Generic;
using Traveller.Core.Contracts;
using Traveller.Core.Repository;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateJourneyCommand : CreateCommand
    {
        public CreateJourneyCommand(ITravellerFactory factory, IDatabase database) : base(factory, database) { }

        public override string Execute(IList<string> parameters)
        {
            string startLocation;
            string destination;
            int distance;
            IVehicle vehicle;

            try
            {
                startLocation = parameters[0];
                destination = parameters[1];
                distance = int.Parse(parameters[2]);
                vehicle = base.Database.Vehicles[int.Parse(parameters[3])];
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateJourney command parameters.");
            }

            var journey = Factory.CreateJourney(startLocation, destination, distance, vehicle);
            base.Database.Journeys.Add(journey);

            return $"Journey with ID {base.Database.Journeys.Count - 1} was created.";
        }
    }
}
