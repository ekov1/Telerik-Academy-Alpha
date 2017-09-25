using System;
using System.Collections.Generic;
using Traveller.Core.Contracts;
using Traveller.Core.Repository;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : CreateCommand
    {
        public CreateAirplaneCommand(ITravellerFactory factory, IDatabase database) : base(factory, database) { }
        
        public override string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = Factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            base.Database.Vehicles.Add(airplane);

            return $"Vehicle with ID {Database.Vehicles.Count - 1} was created.";
        }
    }
}
