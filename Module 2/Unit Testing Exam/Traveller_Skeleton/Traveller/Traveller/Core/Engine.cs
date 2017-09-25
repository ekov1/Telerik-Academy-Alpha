using System;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Core.Contracts.ProviderContracts;
using Traveller.Core.Repository;

namespace Traveller.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "Exit";

        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandProcessor commandProcessor;
        private readonly IDatabase database;

        public Engine(IReader reader, IWriter writer, ICommandProcessor commandProcessor, IDatabase database)
        {
            this.reader = reader ?? throw new ArgumentNullException(nameof(reader));
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
            this.commandProcessor = commandProcessor ?? throw new ArgumentNullException(nameof(commandProcessor));
            this.database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        this.writer.Write(string.Join("\n", this.database.ExecutionResult));
                        break;
                    }

                    string executionResult = this.commandProcessor.ProcessCommand(commandAsString);

                    this.database.ExecutionResult.Add(executionResult);

                }
                catch (Exception ex)
                {
                    this.database.ExecutionResult.Add(ex.Message);
                }
            }
        }
    }
}
