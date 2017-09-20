using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Academy.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";
        private readonly StringBuilder builder = new StringBuilder();

        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IParser parser;

        public Engine(IReader reader, IWriter writer, IParser parser)
        {
            this.reader= reader ?? throw new ArgumentException("reader");
            this.writer = writer ?? throw new ArgumentException("writer");
            this.parser = parser ?? throw new ArgumentException("writer");

            this.Seasons = new List<ISeason>();
            this.Students = new List<IStudent>();
            this.Trainers = new List<ITrainer>();
        }

        public IList<ISeason> Seasons { get; private set; }

        public IList<IStudent> Students { get; private set; }

        public IList<ITrainer> Trainers { get; private set; }


        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString == TerminationCommand)
                    {
                        this.writer.Write(this.builder.ToString());
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    this.builder.AppendLine("Invalid command parameters supplied or the entity with that ID for does not exist.");
                }
                catch (Exception ex)
                {
                    this.builder.AppendLine(ex.Message);
                }
            }
        }

        private void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.parser.ParseCommand(commandAsString);
            var parameters = this.parser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            this.builder.AppendLine(executionResult);
        }
    }
}
