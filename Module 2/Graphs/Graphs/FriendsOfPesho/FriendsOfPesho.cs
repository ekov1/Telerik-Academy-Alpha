using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsOfPesho
{
    public class FriendsOfPesho
    {
        public static void Main(string[] args)
        {
            var inputLineOne = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numberOfDots = inputLineOne[0];
            var numberOfStreets = inputLineOne[1];
            var numberOfHospitals = inputLineOne[2];

            var nodes = new Dictionary<int, char>();

            var hospitals = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var streets = new List<string>();
            for (int i = 0; i < numberOfStreets; i++)
            {
                streets.Add(Console.ReadLine());
            }
        }
    }
}
