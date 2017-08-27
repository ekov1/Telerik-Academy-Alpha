using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_fever
{
    public class GoldFever
    {

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            StockBuySell(price, n);
        }

        private static void StockBuySell(int[] price, int n)
        {
            if (n == 1)
                return;

            int count = 0;

            var buy = new Queue<int>();
            var sell = new Queue<int>();

            int i = 0;
            while (i < n - 1)
            {
                while (i < n - 1 && price[i + 1] <= price[i])
                {
                    i++;
                }

                if (i == n - 1)
                {
                    break;
                }

                buy.Enqueue(i++);

                while (i < n && price[i] >= price[i - 1])
                {
                    buy.Enqueue(i++);
                }

                sell.Enqueue(i - 1);
                buy.Enqueue(-123);

                count++;
            }

            if (count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var ounces = 0;
                var result = 0;

                while (buy.Count != 0)
                {
                    if (buy.Peek() != -123)
                    {
                        ounces++;
                        result -= price[buy.Dequeue()];
                    }
                    else
                    {
                        buy.Dequeue();
                        if (sell.Count == 1)
                        {
                            result += price[sell.Peek()] * ounces;
                        }
                        else
                        {
                            result += price[sell.Dequeue()] * ounces;
                        }

                        ounces = 0;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}