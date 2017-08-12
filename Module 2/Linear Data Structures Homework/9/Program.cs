using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var foundElements = new Queue<int>();

            var operatorCounter = 0;
            for (int i = 0; i < 50; i++)
            {
                switch (operatorCounter)
                {
                    case 0:
                        foundElements.Enqueue(n);
                        operatorCounter = 1;
                        break;

                    case 1:
                        foundElements.Enqueue(foundElements.Peek() + 1);
                        operatorCounter = 2;
                        break;

                    case 2:
                        foundElements.Enqueue(foundElements.Peek() * 2 + 1);
                        operatorCounter = 3;
                        break;

                    case 3:
                        foundElements.Enqueue(foundElements.Peek() + 2);
                        operatorCounter = 4;
                        break;

                    case 4:
                        foundElements.Dequeue();
                        i--;
                        operatorCounter = 1;
                        continue;
                }

                Console.WriteLine(foundElements.Last());
            }
        }
    }
}
