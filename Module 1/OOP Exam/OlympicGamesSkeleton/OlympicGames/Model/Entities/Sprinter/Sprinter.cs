﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Model.Entities
{
    public class Sprinter : Olympian, ISprinter
    {
        private IDictionary<string, double> personalRecords;

        public IDictionary<string, double> PersonalRecords
        {
            get
            {
                return this.personalRecords;                
            }
        }

        public Sprinter(string firstName, string lastName, string country,
            IDictionary<string, double> personalRecords) : base(firstName, lastName, country)
        {
            personalRecords.ValidateIfNull();

            this.personalRecords = personalRecords;
        }

        public override string ToString()
        {
            var commandOutput = new StringBuilder();
            commandOutput.AppendLine($"SPRINTER: {FirstName} {LastName} from {Country}");
            commandOutput.AppendLine($"PERSONAL RECORDS:");
            foreach (var kvp in personalRecords)
            {
                commandOutput.AppendLine($"{kvp.Key}m: {kvp.Value}s");
            }

            return commandOutput.ToString();
        }
    }
}
