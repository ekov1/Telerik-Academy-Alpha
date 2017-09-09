using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _1
{
    public class OrdersStytem
    {
        public static void Main(string[] args)
        {
            var orders = new Orders();

            var numberOfOrders = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOrders; i++)
            {
                var input = Console.ReadLine();

                var inputTokens = input.Split(new[] { ' ' }, 2).ToArray();
                var command = inputTokens[0];
                var commandTokens = inputTokens[1].Split(';').ToArray();

                switch (command)
                {
                    case "AddOrder":
                        orders.AddOrder(commandTokens[0], decimal.Parse(commandTokens[1]), commandTokens[2]);
                        break;

                    case "FindOrdersByConsumer":
                        orders.FindOrdersByConsumer(commandTokens[0]);
                        break;

                    case "DeleteOrders":
                        orders.DeleteOrder(inputTokens[1]);
                        break;

                    case "FindOrdersByPriceRange":
                        orders.FindOrdersByPriceRange(decimal.Parse(commandTokens[0]), decimal.Parse(commandTokens[1]));
                        break;

                }
            }
        }
    }

    public class Order : IComparable<Order>
    {
        private string name;
        private decimal price;
        private string consumer;

        public string Name
        {
            get { return this.name; }
        }

        public decimal Price
        {
            get { return this.price; }
        }

        public string Consumer
        {
            get { return this.consumer; }
        }

        public Order(string name, decimal price, string consumer)
        {
            this.name = name;
            this.price = price;
            this.consumer = consumer;
        }

        public int CompareTo(Order other)
        {
            var result = this.ToString().CompareTo(other.ToString());

            return result;
        }


        public override string ToString()
        {
            return string.Format("{{{0};{1};{2:0.00}}}", name, consumer, price);
        }
    }

    public class Orders
    {
        private Dictionary<string, SortedSet<Order>> ordersSortedByConsumer = new Dictionary<string, SortedSet<Order>>();
        private SortedSet<Order> ordersSortedByPrice = new SortedSet<Order>();

        public void AddOrder(string name, decimal price, string consumer)
        {
            var order = new Order(name, price, consumer);

            if (!ordersSortedByConsumer.ContainsKey(consumer))
            {
                ordersSortedByConsumer.Add(consumer, new SortedSet<Order>());
            }
            ordersSortedByConsumer[consumer].Add(order);

            ordersSortedByPrice.Add(order);

            Console.WriteLine("Order added");
        }

        public void DeleteOrder(string consumer)
        {
            if (ordersSortedByConsumer.ContainsKey(consumer))
            {
                Console.WriteLine("{0} orders deleted", ordersSortedByConsumer[consumer].Count);
                ordersSortedByConsumer.Remove(consumer);
            }
            else
            {
                Console.WriteLine("No orders found");
            }
        }

        public void FindOrdersByPriceRange(decimal min, decimal max)
        {
            bool hasOrder = false;
            foreach (var order in ordersSortedByPrice.Where(x => x.Price >= min && x.Price <= max && ordersSortedByConsumer.ContainsKey(x.Consumer)))
            {
                Console.WriteLine(order);
                hasOrder = true;
            }

            if (!hasOrder)
            {
                Console.WriteLine("No orders found");
            }
        }

        public void FindOrdersByConsumer(string consumer)
        {
            if (ordersSortedByConsumer.ContainsKey(consumer))
            {
                foreach (var order in ordersSortedByConsumer[consumer])
                {
                    Console.WriteLine(order);
                }
            }
            else
            {
                Console.WriteLine("No orders found");
            }
        }
    }
}
