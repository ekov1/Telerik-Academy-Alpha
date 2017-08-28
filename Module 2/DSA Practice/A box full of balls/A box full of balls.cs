using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_box_full_of_balls
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var moves = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var ab = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int a = ab[0];
            int b = ab[1];

            var isWins = new bool[b + 1];
            isWins[0] = false;

            for (int i = 1; i < b + 1; i++)
            {
                foreach (var m in moves)
                {
                    if (m > i)
                    {
                        continue;
                    }
                    if (!isWins[i - m])
                    {
                        isWins[i] = true;
                    }
                }
            }

            int total = 0;
            for (int i = a; i < b + 1; i++)
            {
                if (isWins[i])
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
