using System;
using System.Collections.Generic;
using System.Linq;

namespace Aquapark
{
    public class Aquapark
    {
        public static void Main(string[] args)
        {
            var slideQueue = new Queue<int>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var commandParams = Console.ReadLine()
                    .Split(' ');

                switch (commandParams[0])
                {
                    case "add":
                        var ID = int.Parse(commandParams[1]);
                        slideQueue.Enqueue(ID);
                        Console.WriteLine("Added {0}", ID);
                        break;

                    case "slide":
                        var numberOfSlides = int.Parse(commandParams[1]);
                        for (int k = 0; k < numberOfSlides % slideQueue.Count; k++)
                        {
                            slideQueue.Enqueue(slideQueue.Dequeue());
                        }

                        Console.WriteLine("Slided {0}", numberOfSlides);
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", slideQueue.Reverse()));
                        break;
                }
            }
        }
    }
}