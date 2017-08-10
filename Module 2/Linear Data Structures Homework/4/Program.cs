using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            var uniqueNumbersCounts = new List<int>();

            var counter = 1;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1] && i != list.Count - 2)
                {
                    counter++;
                }
                else
                {
                    if (i == list.Count - 2)
                    {
                        counter++;
                    }

                    uniqueNumbersCounts.Add(counter);
                    counter = 1;
                }
            }

            Console.WriteLine(uniqueNumbersCounts.Max());
        }
    }
}
