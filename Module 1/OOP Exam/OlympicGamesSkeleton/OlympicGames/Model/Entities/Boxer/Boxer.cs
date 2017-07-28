using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Model.Entities
{
    public class Boxer : Olympian, IBoxer
    {
        private BoxingCategory category;
        private int wins;
        private int losses;

        public BoxingCategory Category
        {
            get
            {
                return this.category;               
            }
        }

        public int Wins
        {
            get
            {
                return this.wins;               
            }
        }

        public int Losses
        {
            get
            {
                return this.losses;                
            }
        }

        public Boxer(string firstName, string lastName, string country, string category, int wins,
            int losses) : base(firstName, lastName, country)
        {
            category.ValidateIfNull();
            wins.ValidateIfNull();
            wins.ValidateMinAndMaxNumber(0, 100);
            losses.ValidateIfNull();
            losses.ValidateMinAndMaxNumber(0, 100);

            BoxingCategory boxingCategory;

            if (category == "heavyweight")
            {
                boxingCategory = BoxingCategory.Heavyweight;
            }
            else if (category == "lightweight")
            {
                boxingCategory = BoxingCategory.Lightweight;
            }
            else if (category == "flyweight")
            {
                boxingCategory = BoxingCategory.Flyweight;
            }
            else if (category == "featherweight")
            {
                boxingCategory = BoxingCategory.Featherweight;
            }
            else
            {
                boxingCategory = BoxingCategory.Middleweight;                
            }

            this.category = boxingCategory;
            this.wins = wins;
            this.losses = losses;           
        }

        public override string ToString()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return $@"BOXER: {FirstName} {LastName} from {Country}
Category: {textInfo.ToTitleCase(this.category.ToString())}
Wins: {wins}
Losses: {losses}";
        }
    }
}
