using System.Text;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        private bool hasFreeFood;

        public bool HasFreeFood
        {
            get { return this.hasFreeFood; }
            private set { this.hasFreeFood = value; }
        }

        public Airplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood)
        {
            this.PassangerCapacity = passengerCapacity;
            this.PricePerKilometer = pricePerKilometer;
            this.HasFreeFood = hasFreeFood;
            this.Type = VehicleType.Air;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Airplane ----");
            result.AppendLine($"Passenger capacity: {this.PassangerCapacity}");
            result.AppendLine($"Price per kilometer: {this.PricePerKilometer}");
            result.AppendLine($"Vehicle type: {this.Type}");
            result.Append($"Has free food: {this.HasFreeFood}");

            return result.ToString();
        }
    }
}
