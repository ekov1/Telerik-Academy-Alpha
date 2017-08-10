using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var watch = new Stopwatch();
            var linkedList = new LinkedList<int>();
            for (int i = 0; i < 10000000; i++)
            {
                if (i % 6 == 0)
                {
                    linkedList.AddLast(i * -1);
                }
                else
                {
                    linkedList.AddLast(i * -1);
                }
            }

            watch.Start();
            for (var node = linkedList.First; node != null; node = node.Next)
            {
                if (node.Value < 0)
                {
                    linkedList.Remove(node);
                    node = linkedList.First;
                }
            }

            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
