using System;
using System.Collections.Generic;
using Traveller.Core.Contracts;
using Traveller.Core.Repository;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : CreateCommand
    {
        public CreateTrainCommand(ITravellerFactory factory, IDatabase database) : base(factory, database) { }

        public override string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = Factory.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            Database.Vehicles.Add(train);

            return $"Vehicle with ID {Database.Vehicles.Count - 1} was created.";
        }
    }
}
