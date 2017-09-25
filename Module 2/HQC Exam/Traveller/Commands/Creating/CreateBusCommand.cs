using System;
using System.Collections.Generic;
using Traveller.Core.Contracts;
using Traveller.Core.Repository;

namespace Traveller.Commands.Creating
{
    public class CreateBusCommand : CreateCommand
    {
        public CreateBusCommand(ITravellerFactory factory, IDatabase database) : base(factory, database) { }

        public override string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateBus command parameters.");
            }

            var bus = Factory.CreateBus(passengerCapacity, pricePerKilometer);
            base.Database.Vehicles.Add(bus);

            return $"Vehicle with ID {base.Database.Vehicles.Count - 1} was created.";
        }
    }
}
