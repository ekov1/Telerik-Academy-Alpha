using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreateVehicleCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public ITravellerFactory Factory
        {
            get { return this.factory; }
        }

        public IEngine Engine
        {
            get { return this.engine; }
        }

        public CreateVehicleCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public abstract string Execute(IList<string> parameters);
    }
}
