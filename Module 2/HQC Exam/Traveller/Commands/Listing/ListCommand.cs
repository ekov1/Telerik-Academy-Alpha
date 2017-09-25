using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Repository;

namespace Traveller.Commands.Listing
{
    public abstract class ListCommand : ICommand
    {
        protected IDatabase Database { get; }

        protected ListCommand(IDatabase database)
        {
            this.Database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public abstract string Execute(IList<string> parameters);
    }
}
