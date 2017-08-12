using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var alreadyCalculatedNumbers = new SortedDictionary<int, int>();

            var numbers = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (!alreadyCalculatedNumbers.ContainsKey(number))
                {
                    var timesNumberOccurs = numbers.Count(x => x == number);

                    alreadyCalculatedNumbers.Add(number, timesNumberOccurs);
                }
            }

            foreach (var kvp in alreadyCalculatedNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
