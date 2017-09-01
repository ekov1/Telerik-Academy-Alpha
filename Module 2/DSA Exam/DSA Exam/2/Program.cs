using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _2
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            var set = new HashSet<int>();
            var list = new List<int>();

            var numberOfCommands = int.Parse(Console.ReadLine());
            var commands = new List<string[]>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split(' ');
                commands.Add(command);

                var x = int.Parse(command[0]);
                var y = int.Parse(command[3]);

                if (!set.Contains(x))
                {
                    list.Add(x);
                    set.Add(x);
                }

                if (!set.Contains(y))
                {
                    list.Add(y);
                    set.Add(y);
                }
            }

            var biglist =  new BigList<int>(list.Distinct());

            foreach (var command in commands)
            {
                var x = int.Parse(command[0]);
                var y = int.Parse(command[3]);
                var k = command[2];

                biglist.Remove(x);

                if (k == "after")
                {
                   biglist.Insert(biglist.IndexOf(y) + 1, x);
                }
                else
                {
                    if(x != 0)
                    { }
                    biglist.Insert(biglist.IndexOf(y), x);
                }              
            }


            Console.WriteLine(string.Join("", biglist));
        }
    }
}
