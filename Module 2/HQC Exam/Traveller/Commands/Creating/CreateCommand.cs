using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Core.Repository;

namespace Traveller.Commands.Creating
{
    public abstract class CreateCommand : ICommand
    {
        protected ITravellerFactory Factory { get; }
        protected IDatabase Database { get; }

        protected CreateCommand(ITravellerFactory factory, IDatabase database)
        {
            this.Factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this.Database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public abstract string Execute(IList<string> parameters);
    }
}
