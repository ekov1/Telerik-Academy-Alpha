using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Exceptions;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Bus : Vehicle, IBus
    {
        public Bus(int passengerCapacity, decimal pricePerKilometer)
        {
            Validator.ValidateCapacity("bus", passengerCapacity, 10, 50);
            this.PassangerCapacity = passengerCapacity;

            this.PricePerKilometer = pricePerKilometer;
            
            this.Type = VehicleType.Land;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Bus ----");
            result.AppendLine($"Passenger capacity: {this.PassangerCapacity}");
            result.AppendLine($"Price per kilometer: {this.PricePerKilometer}");
            result.Append($"Vehicle type: {this.Type}");

            return result.ToString();
        }
    }
}
