using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Drivers.Abstract
{
    public abstract class Driver : IDriver
    {
        private readonly int id;
        private readonly string name;
        private readonly GenderType gender;
        private readonly List<IMotorVehicle> vehicles;

        public Driver(string name, GenderType gender)
        {
            this.id = DataGenerator.GenerateId();
            this.name = name;
            this.gender = gender;
            this.vehicles = new List<IMotorVehicle>();
        }

        public IMotorVehicle ActiveVehicle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public GenderType Gender
        {
            get { return this.gender; }
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public IEnumerable<IMotorVehicle> Vehicles
        {
            get { return this.vehicles; }
        }

        public void AddVehicle(IMotorVehicle vehicle)
        {
            this.vehicles.Add(vehicle);
        }
        public bool RemoveVehicle(IMotorVehicle vehicle)
        {
            throw new NotImplementedException();
        }
        public void SetActiveVehicle(IMotorVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
