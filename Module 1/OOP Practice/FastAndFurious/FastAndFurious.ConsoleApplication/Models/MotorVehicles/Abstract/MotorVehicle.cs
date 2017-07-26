using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Exceptions;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    public abstract class MotorVehicle : IMotorVehicle, IWeightable, IValuable
    {
        private decimal price;
        private int weight;
        private int acceleration;
        private int topSpeed;
        private List<int> tuningParts;

        public MotorVehicle(decimal price, int weight, int topSpeed, int acceleration)
        {
            this.price = price;
            this.weight = weight;
            this.topSpeed = topSpeed;
            this.acceleration = acceleration;
            this.tuningParts = new List<int>();
        }

        public decimal Price
        {
            get
            {
                return this.price + this.TunningParts.Sum(x => x.Price);
            }
        }
        public int Weight
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public int Acceleration
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public int TopSpeed
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public IEnumerable<ITunningPart> TunningParts
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddTunning(ITunningPart part)
        {
            throw new NotImplementedException();
        }
        public TimeSpan Race(int trackLengthInMeters)
        {
            // Oohh boy, you shouldn't have missed the PHYSICS class in high school.
            throw new NotImplementedException();
        }
        public bool RemoveTunning(ITunningPart part)
        {
            throw new NotImplementedException();
        }
    }
}
