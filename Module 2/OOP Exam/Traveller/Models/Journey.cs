using System.Text;
using Traveller.Exceptions;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models
{
    public class Journey : IJourney
    {
        public string startLocation;
        public string destination;
        public int distance;
        public IVehicle vehicle;

        public string StartLocation
        {
            get { return this.startLocation; }
        }

        public string Destination
        {
            get { return this.destination; }
        }

        public int Distance
        {
            get { return this.distance; }
        }

        public IVehicle Vehicle
        {
            get { return this.vehicle; }
        }

        public Journey(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            Validator.LengthValidator("StartingLocation", startLocation, 5, 25);
            this.startLocation = startLocation;

            Validator.LengthValidator("Destination", destination, 5, 25);
            this.destination = destination;

            Validator.DistanceValidator(distance);
            this.distance = distance;

            this.vehicle = vehicle;
        }

        public decimal CalculateTravelCosts()
        {
            return this.Distance * vehicle.PricePerKilometer;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Journey ----");
            result.AppendLine($"Start location: {this.StartLocation}");
            result.AppendLine($"Destination: {this.Destination}");
            result.AppendLine($"Distance: {this.Distance}");
            result.AppendLine($"Vehicle type: {this.Vehicle.Type}");
            result.Append($"Travel costs: {CalculateTravelCosts()}");

            return result.ToString();
        }
    }
}
