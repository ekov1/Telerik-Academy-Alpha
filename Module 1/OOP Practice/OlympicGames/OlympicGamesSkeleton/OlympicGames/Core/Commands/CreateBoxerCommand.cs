using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Factories;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : CreateCommand
    {
        private string category;
        private int wins;
        private int losses;

        public CreateBoxerCommand(IList<string> commandParameters) : base(commandParameters)
        {
            if (commandParameters.Count != 6)
            {
                throw new ArgumentException($"{GlobalConstants.ParametersCountInvalid}");
            }

            //gives category an uppercase
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.category = textInfo.ToTitleCase(commandParameters[3].Trim());

            //valida
            string wins = commandParameters[4];

            string losses = commandParameters[5];

            int number;

            if (!(int.TryParse(wins, out number) && int.TryParse(losses, out number)))

            {
                throw new ArgumentException(GlobalConstants.WinsLossesMustBeNumbers);
            }
            int.Parse(wins).ValidateWins();
            this.wins = int.Parse(wins); 

            int.Parse(losses).ValidateLosses();
            this.losses = int.Parse(losses);
        }

        public override string Execute()
        {
            Committee.Olympians.Add(OlympicsFactory.Instance.CreateBoxer(this.FristName, this.LastName, this.Country, this.category, this.wins, this.losses));

            var output = new StringBuilder();
            output.AppendLine("Created Boxer");
            output.AppendLine(Committee.Olympians.Last().ToString());

            return output.ToString();
        }
    }
}
