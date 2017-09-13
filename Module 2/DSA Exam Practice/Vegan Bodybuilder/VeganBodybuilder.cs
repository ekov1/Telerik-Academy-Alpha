using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan_Bodybuilder
{
    public class VeganBodybuilder
    {
        private static int maxWeight;
        private static int numberOfChoices;
        private static List<int[]> choicesStats;
        private static List<string> choicesName;
        private static List<string> optimalChoices;

        public static void Main()
        {
             maxWeight = int.Parse(Console.ReadLine());
             numberOfChoices = int.Parse(Console.ReadLine());
             choicesStats = new List<int[]>();
             choicesName = new List<string>();
             optimalChoices = new List<string>();
               
            for (int i = 0; i < numberOfChoices; i++)
            {
                var choicesTokens = Console.ReadLine().Split(' ');
                choicesStats.Add(choicesTokens.Skip(1).Select(int.Parse).ToArray());
                choicesName.Add(choicesTokens.First());
            }

            var currentChoice = numberOfChoices - 1;

            var optimalValue = Knapsack(currentChoice, maxWeight);

            Console.WriteLine(optimalValue);

            var k = 1;

            for (int i = optimalChoices.Count - 1; i >= 0; i--)
            {
                optimalValue -= choicesStats[choicesStats.Count - k][1];
                k++;

                if (optimalValue < 0)
                {
                    break;
                }

                Console.WriteLine(optimalChoices[i]);
            }
        }

        private static int Knapsack(int currentChoice, int capacityLeft)
        {
            int result;

            if (currentChoice <= 0 || capacityLeft <= 0)
            {
                return 0;
            }

            var weight = choicesStats[currentChoice][0];
            var value = choicesStats[currentChoice][1];

            if (weight > capacityLeft)
            {
                result = Knapsack(currentChoice - 1, capacityLeft);
            }
            else
            {
                var tempOne = Knapsack(currentChoice - 1, capacityLeft);
                var tempTwo = value + Knapsack(currentChoice - 1, capacityLeft - weight);
                result = new [] {tempOne, tempTwo}.Max();

                if (tempTwo > tempOne)
                {
                    optimalChoices.Add(choicesName[currentChoice]);
                }
            }

            return result;
        }
    }
}