using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Core.Repository;
using Traveller.Models;
using Traveller.Models.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : CreateCommand
    {
        public CreateTicketCommand(ITravellerFactory factory, IDatabase database) : base(factory, database) { }

        public override string Execute(IList<string> parameters)
        {
            IJourney journey;
            decimal administrativeCosts;

            try
            {
                journey = base.Database.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = Factory.CreateTicket(journey, administrativeCosts);
            base.Database.Tickets.Add(ticket);

            return $"Ticket with ID {base.Database.Tickets.Count - 1} was created.";
        }
    }
}
