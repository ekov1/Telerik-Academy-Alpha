using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var numberOfCommands = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "add")
                {
                    var n = int.Parse(command[1]);
                    Console.WriteLine("Added {0}", n);
                    queue.Enqueue(n);
                }
                else if (command[0] == "slide")
                {
                    var n = int.Parse(command[1]);
                    for (int k = 0; k < n % queue.Count; k++)
                    {
                        queue.Enqueue(queue.Dequeue());
                    }

                    Console.WriteLine("Slided {0}", n);
                }
                else if (command[0] == "print")
                {
                    Console.WriteLine(string.Join(" ", queue.Reverse()));
                }
            }
        }
    }
}