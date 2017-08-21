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
    public class CreateAirplaneCommand : CreateVehicleCommand
    {
        public CreateAirplaneCommand(ITravellerFactory factory, IEngine engine) : base(factory, engine) { }

        public override string Execute(IList<string> parameters)
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

            var airplane = this.Factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.Engine.Vehicles.Add(airplane as IVehicle);

            return $"Vehicle with ID {Engine.Vehicles.Count - 1} was created.";
        }

        
    }
}
