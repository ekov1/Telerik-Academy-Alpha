using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_ranking
{
    public class PlayerRanking
    {
        public static void Main(string[] args)
        {
            var playerCollector = new PlayerCollector();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var inputTokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (inputTokens[0])
                {
                    case "add":
                        var name = inputTokens[1];
                        var type = inputTokens[2];
                        var age = int.Parse(inputTokens[3]);
                        var position = int.Parse(inputTokens[4]);
                        playerCollector.AddPlayer(name, type, age, position);
                        Console.WriteLine("Added player {0} to position {1}", name, position);
                        break;

                    case "find":
                        var playerType = inputTokens[1];
                        var topPlayersOfGivenType = playerCollector.FindPlayerType(playerType);
                        var result = string.Format("Type {0}: {1}", playerType, string.Join("; ", topPlayersOfGivenType));
                        Console.WriteLine(result);
                        break;

                    case "ranklist":
                        var min = int.Parse(inputTokens[1]);
                        var max = int.Parse(inputTokens[2]);
                        var rankList = playerCollector.RankList(min, max);

                        var n = 1;
                        foreach (var player in rankList)
                        {
                            if (n != rankList.Count)
                            {
                                Console.Write("{0}. {1}({2}); ", n, player.Name, player.PlayerAge);
                            }
                            else
                            {
                                Console.Write("{0}. {1}({2})", n, player.Name, player.PlayerAge);
                                Console.WriteLine();
                            }
                            n++;
                        }

                        break;
                }
            }
        }
    }

    public class Player
    {
        private string name;
        private string playerType;
        private int playerAge;

        public string Name
        {
            get { return this.name; }
        }

        public string PlayerType
        {
            get { return this.playerType; }
        }

        public int PlayerAge
        {
            get { return this.playerAge; }
        }

        public Player(string name, string playerType, int playerAge)
        {
            this.name = name;
            this.playerType = playerType;
            this.playerAge = playerAge;
        }
    }

    public class PlayerCollector
    {
        private List<Player> playerCollection = new List<Player>();

        public void AddPlayer(string name, string playerType, int playerAge, int playerPosition)
        {
            var player = new Player(name, playerType, playerAge);

            playerCollection.Insert(playerPosition - 1, player);
        }

        public List<string> FindPlayerType(string playerType)
        {
            return this.playerCollection
                .Where(x => x.PlayerType == playerType)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.PlayerAge)
                .Take(5)
                .Select(x => string.Format("{0}({1})", x.Name, x.PlayerAge))
                .ToList();
        }

        public List<Player> RankList(int start, int end)
        {
            if (end > playerCollection.Count)
            {
                end = playerCollection.Count;
            }
            return playerCollection.GetRange(start - 1, end);
        }
    }
}
