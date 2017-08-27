using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    public class Conference
    {
        public static void Main(string[] args)
        {
            var inputTokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numberOfDevelopers = inputTokens[0];
            var developerPairsNumber = inputTokens[1];

            var developerPairs = new List<int[]>();
            for (int i = 0; i < developerPairsNumber; i++)
            {
                developerPairs.Add(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }


            var result = 0;

            for (int i = 1; i < developerPairs.Count; i++)
            {
                result *= developerPairs[i].Length;
            }

            Console.WriteLine(result);
        }
    }
}
