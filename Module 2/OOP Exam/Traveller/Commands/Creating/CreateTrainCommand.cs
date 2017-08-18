using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public CreateTrainCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cars;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cars = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = this.factory.CreateTrain(passengerCapacity, pricePerKilometer, cars);
            this.engine.Vehicles.Add(train as IVehicle);

            return $"Vehicle with ID {engine.Vehicles.Count - 1} was created.";
        }
    }
}
