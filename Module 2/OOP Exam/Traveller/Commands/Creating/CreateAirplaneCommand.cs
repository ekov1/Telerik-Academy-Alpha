using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Traveller.Core.Contracts;
using Traveller.Models.Vehicles.Contracts;
using ICommand = Traveller.Commands.Contracts.ICommand;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public CreateAirplaneCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2].ToLower());
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = this.factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.engine.Vehicles.Add(airplane as IVehicle);

            return $"Vehicle with ID {engine.Vehicles.Count - 1} was created.";
        }

        
    }
}
