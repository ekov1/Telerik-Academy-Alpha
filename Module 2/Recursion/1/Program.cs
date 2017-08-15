using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Programwqqq2213
    {
        public static void Main()
        {
            PrintNestedLoops(3);
        }

        private static void PrintNestedLoops(int loopCount)
        {
            IterateNestedLoops(new Stack<int>(), 0, loopCount);
        }

        private static void IterateNestedLoops(Stack<int> nestedLoops, int currentIteration, int iterationCount)
        {

            if (currentIteration == iterationCount)
            {
                Console.WriteLine(string.Join(" ", nestedLoops.Reverse()));
                return;
            }

            for (int currentNumber = 1; currentNumber <= iterationCount; currentNumber++)
            {
                nestedLoops.Push(currentNumber);
                IterateNestedLoops(nestedLoops, currentIteration + 1, iterationCount);
                nestedLoops.Pop();
            }
        }
    }
}
