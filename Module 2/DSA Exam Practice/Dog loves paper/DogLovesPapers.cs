using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog_loves_paper
{
    public class DogLovesPapers
    {
        private const int infinity = int.MaxValue;

        private static List<List<int>> graph = new List<List<int>>();
        private static List<int> parents = new List<int>(Enumerable.Repeat(infinity, 10));

        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                graph.Add(new List<int>());
            }

            for (int i = 0; i < numberOfLines; i++)
            {
                var lineTokens = Console.ReadLine()
                    .Split(new [] {" ", "is"}, StringSplitOptions.RemoveEmptyEntries);

                int firstNode = int.Parse(lineTokens[0]);
                int secondNode = int.Parse(lineTokens[2]);

                if (parents[firstNode] == infinity)
                {
                    parents[firstNode] = 0;
                }

                if (parents[secondNode] == infinity)
                {
                    parents[secondNode] = 0;
                }


                if (lineTokens[1] == "after")
                {
                    graph[secondNode].Add(firstNode);
                    {
                        parents[firstNode]++;
                    }

                }
                else
                {
                    graph[firstNode].Add(secondNode);
                    {
                        parents[secondNode]++;
                    }
                }
            }

            bool firstIteration = true;

            int zeroValue = parents[0];

            var result = new StringBuilder();

            while (!parents.All(x => x == infinity))
            {
                if (firstIteration)
                {
                    parents[0] = infinity;
                }

                int minNodeId = parents.IndexOf(parents.Min());

                if (firstIteration)
                {
                    parents[0] = zeroValue;
                }

                graph[minNodeId].ForEach(childId => parents[childId]--);

                parents[minNodeId] = infinity;
                result.Append(minNodeId);

                firstIteration = false;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
