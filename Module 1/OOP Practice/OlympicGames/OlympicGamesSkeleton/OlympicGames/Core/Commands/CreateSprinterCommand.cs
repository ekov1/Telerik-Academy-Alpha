using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : CreateCommand
    {
        private readonly IDictionary<string, double> records = new Dictionary<string, double>();


        public CreateSprinterCommand(IList<string> commandParameters) : base(commandParameters)
        {
            var recordsParams = commandParameters.Skip(3).ToList();

            foreach (var record in recordsParams)
            {
                var recordTokens = record.Split('/');
                
                records.Add(recordTokens[0], double.Parse(recordTokens[1]));
            }
        }

        public override string Execute()
        {
            Committee.Olympians.Add(OlympicsFactory.Instance.CreateSprinter(base.FristName, base.LastName, base.Country, this.records));

            var output = new StringBuilder();
            output.AppendLine($"Created Sprinter");
            output.AppendLine(Committee.Olympians.Last().ToString());

            return output.ToString();
        }
    }
}
