using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Commands.Listing;
using Traveller.Core.Repository;

namespace Traveller.Commands.Creating
{
    public class ListJourneysCommand : ListCommand, ICommand
    {
        public ListJourneysCommand(IDatabase database) : base(database) { }

        public override string Execute(IList<string> parameters)
        {
            var journeys = base.Database.Journeys;

            if (journeys.Count == 0)
            {
                return "There are no registered journeys.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, journeys);
        }
    }
}
