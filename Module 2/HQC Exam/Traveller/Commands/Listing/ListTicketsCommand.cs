using System;
using System.Collections.Generic;
using Traveller.Commands.Listing;
using Traveller.Core.Repository;

namespace Traveller.Commands.Creating
{
    public class ListTicketsCommand : ListCommand
    {
        public ListTicketsCommand(IDatabase database) : base(database) { }

        public override string Execute(IList<string> parameters)
        {
            var tickets = Database.Tickets;

            if (tickets.Count == 0)
            {
                return "There are no registered tickets.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, tickets);
        }
    }
}
