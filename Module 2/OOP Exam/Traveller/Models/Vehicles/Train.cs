using System.Text;
using Traveller.Exceptions;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Train : Vehicle, ITrain
    {
        private int carts;

        public int Carts
        {
            get { return this.carts; }
            set { this.carts = value; }
        }

        public Train(int passengerCapacity, decimal pricePerKilometer, int carts)
        {
            Validator.ValidateCapacity("train", passengerCapacity, 30, 150);
            this.PassangerCapacity = passengerCapacity;

            this.PricePerKilometer = pricePerKilometer;

            Validator.ValidateCarts(carts);
            this.Carts = carts;

            this.Type = VehicleType.Land;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("Train ----");
            result.AppendLine($"Passenger capacity: {this.PassangerCapacity}");
            result.AppendLine($"Price per kilometer: {this.PricePerKilometer}");
            result.AppendLine($"Vehicle type: {this.Type}");
            result.Append($"Carts amount: {this.Carts}");

            return result.ToString();
        }
    }
}
