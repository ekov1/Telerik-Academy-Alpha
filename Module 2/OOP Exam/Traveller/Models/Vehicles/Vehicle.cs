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
    public abstract class Vehicle : IVehicle
    {
        private int passangerCapactiy;
        private VehicleType type;
        private decimal pricePerKilometer;

        public int PassangerCapacity
        {
            get { return this.passangerCapactiy; }
            set
            {   
                Validator.ValidateVehicaleCapacity(value);
                this.passangerCapactiy = value;
            }
        }

        public VehicleType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public decimal PricePerKilometer
        {
            get { return this.pricePerKilometer; }
            set
            {
                Validator.PricePerKilometerValidator(value);
                this.pricePerKilometer = value;
            }
        }

        public abstract override string ToString();
    }
}
