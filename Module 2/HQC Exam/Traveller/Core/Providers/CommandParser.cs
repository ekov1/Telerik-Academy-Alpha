using System.Collections.Generic;
using System.Linq;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts.FactoryContracts;

namespace Traveller.Core.Providers
{
    public class CommandParser : IParser
    {
        private readonly ICommandFactory factory;

        public CommandParser(ICommandFactory factory)
        {
            this.factory = factory;
        }

        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split()[0];
            var command = this.factory.CreateCommand(commandName);

            return command;
        }

        public IList<string> ParseParameters(string fullCommand)
        {
            var commandParts = fullCommand.Split().Skip(1).ToList();
            if (commandParts.Count == 0)
            {
                return new List<string>();
            }

            return commandParts;
        }
    }
}
