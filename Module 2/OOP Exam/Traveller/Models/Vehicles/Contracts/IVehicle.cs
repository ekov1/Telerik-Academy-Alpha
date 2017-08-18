using System;
using Traveller.Models.Enums;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        int PassangerCapacity { get; set; }
        VehicleType Type { get; set; }
        decimal PricePerKilometer { get; set; }
        string ToString();
    }
}