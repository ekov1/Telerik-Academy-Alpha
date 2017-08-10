using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == string.Empty)
                {
                    break;
                }

                var number = int.Parse(input);
                if (number >= 0)
                {
                    numbers.Add(number);
                }
            }

            Console.WriteLine(numbers.Average());
        }
    }
}
