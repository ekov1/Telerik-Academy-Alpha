using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;

namespace OlympicGames.Olympics.Entities
{
    public class Boxer : Olympian, IBoxer
    {
        private BoxingCategory category;
        private int wins;
        private int losses;

        public BoxingCategory Category
        {
            get { return this.category; }
        }

        public int Wins
        {
            get { return this.wins; }         
        }

        public int Losses
        {
            get { return this.losses; }
        }

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins,
            int losses) : base(firstName, lastName, country)
        {
            this.category = category;
            this.wins = wins;
            this.losses = losses;
        }

        public override string ToString()
        {
            return $@"BOXER: {base.FirstName} {base.LastName} from {base.Country}
Category: {this.category}
Wins: {this.wins}
Losses: {this.losses}";
        }
    }
}
