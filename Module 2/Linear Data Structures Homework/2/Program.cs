using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stackedNumbers = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            var n = stackedNumbers.Count;
            for (int i = 0; i < n; i++)
            {
                Console.Write(stackedNumbers.Pop() + " ");
            }
        }
    }
}
