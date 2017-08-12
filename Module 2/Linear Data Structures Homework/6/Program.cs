using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = new List<int>();
            var alreadyCalculatedNumbers = new Dictionary<int, int>();

            var numbers = Console.ReadLine()
                .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                //memorization
                var number = numbers[i];
                if (alreadyCalculatedNumbers.ContainsKey(number))
                {
                    if (alreadyCalculatedNumbers[number] % 2 == 0)
                    {
                        result.Add(number);
                    }
                }
                else
                {
                    var timesNumberOccurs = numbers.Count(x => x == number);
                    if (timesNumberOccurs % 2 == 0)
                    {
                        result.Add(numbers[i]);
                    }

                    alreadyCalculatedNumbers.Add(number, timesNumberOccurs);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
