using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : CreateVehicleCommand
    {
        public CreateTrainCommand(ITravellerFactory factory, IEngine engine) : base(factory, engine) { }

        public override string Execute(IList<string> parameters)
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

            var train = this.Factory.CreateTrain(passengerCapacity, pricePerKilometer, cars);
            this.Engine.Vehicles.Add(train as IVehicle);

            return $"Vehicle with ID {Engine.Vehicles.Count - 1} was created.";
        }
    }
}
