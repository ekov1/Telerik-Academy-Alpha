using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command
    {
        private string key;
        private string order;

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            commandParameters.ValidateIfNull();
            key = string.Join(" ", commandParameters.Take(1));
            order = string.Join(" ", commandParameters.Skip(1));

            if (this.key == string.Empty)
            {
                this.key = "firstname";
            }

            if (this.order == string.Empty)
            {
                this.order = "asc";
            }
        }

        // Use it. It works!
        public override string Execute()
        {
            if (Committee.Olympians.Count == 0)
            {
                return GlobalConstants.NoOlympiansAdded;
            }

            var stringBuilder = new StringBuilder();
            var sorted = this.Committee.Olympians.ToList();

            stringBuilder.AppendLine(string.Format(GlobalConstants.SortingTitle, this.key, this.order));


            if (this.order == "desc")
            {
                if (this.key == "firstname")
                {
                    sorted = this.Committee.Olympians.OrderByDescending(x => x.FirstName).ToList();
                }
                else
                {
                    sorted = this.Committee.Olympians.OrderByDescending(x => x.LastName).ToList();
                }
            }
            else
            {
                if (this.key == "firstname")
                {
                    sorted = this.Committee.Olympians.OrderBy(x => x.FirstName).ToList();
                }
                else
                {
                    sorted = this.Committee.Olympians.OrderBy(x => x.LastName).ToList();
                }
            }

            foreach (var item in sorted)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
