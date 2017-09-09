using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace Orders_System
{
    public class OrdersSystem
    {
        public static void Main(string[] args)
        {
            var orders = new Orders();

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandParams = Console.ReadLine().Split(new char[] {' '}, 2);

                switch (commandParams[0])
                {
                    case "AddOrder":
                        var orderParams = commandParams[1].Split(';');
                        orders.AddOrder(orderParams[0], decimal.Parse(orderParams[1]), orderParams[2]);
                        break;

                    case "DeleteOrders":
                        orders.DeleteOrders(commandParams[1]);
                        break;

                    case "FindOrdersByConsumer":
                        orders.FindOrdersByConsumer(commandParams[1]);
                        break;

                    case "FindOrdersByPriceRange":
                        var priceRangeParams = commandParams[1].Split(';').Select(decimal.Parse).ToArray();
                        orders.FindOrdersByPriceRange(priceRangeParams[0], priceRangeParams[1]);
                        break;

                }
            }
        }
    }

    public class Orders
    {
        static Dictionary<string, OrderedBag<Order>> ordersByConsumer = new Dictionary<string, OrderedBag<Order>>();
        static OrderedDictionary<decimal, OrderedBag<Order>> ordersByPrice = new OrderedDictionary<decimal, OrderedBag<Order>>();


        public void AddOrder(string name, decimal price, string consumer)
        {
            var order = new Order(name, price, consumer);

            if (!ordersByConsumer.ContainsKey(consumer))
            {
                ordersByConsumer.Add(consumer, new OrderedBag<Order>());
            }
            ordersByConsumer[consumer].Add(order);

            if (!ordersByPrice.ContainsKey(price))
            {
                ordersByPrice.Add(price, new OrderedBag<Order>());
            }
            ordersByPrice[price].Add(order);

            Console.WriteLine("Order added");
        }

        public void DeleteOrders(string consumer)
        {
            if (ordersByConsumer.ContainsKey(consumer) && ordersByConsumer[consumer].Count > 0)
            {
                int count = 0;

                while (ordersByConsumer[consumer].Count > 0)
                {
                    Order order = ordersByConsumer[consumer][0];

                    ordersByPrice[order.Price].Remove(order);
                    ordersByConsumer[consumer].Remove(order);

                    count++;
                }

                Console.WriteLine("{0} orders deleted", count);
            }
            else
            {
                Console.WriteLine("No orders found");
            }
        }

        public void FindOrdersByPriceRange(decimal min, decimal max)
        {
            IEnumerable<OrderedBag<Order>> bagComparer = ordersByPrice.Range(min, true, max, true).Values;

            var orders = bagComparer.SelectMany(b => b).OrderBy(b => b.Name).ToArray();

            if (orders.Length == 0)
            {
                Console.WriteLine("No orders found");

                return;
            }

            foreach (var order in orders)
            {
                Console.WriteLine(string.Join("\n", order));
            }
        }

        public void FindOrdersByConsumer(string consumer)
        {
            if (ordersByConsumer.ContainsKey(consumer) && ordersByConsumer[consumer].Count > 0)
            {
                OrderedBag<Order> result = ordersByConsumer[consumer];
                Console.WriteLine(string.Join("\n", result));
            }
            else
            {
                Console.WriteLine("No orders found");
            }
        }
    }

    public class Order : IComparable<Order>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Consumer { get; set; }

        public Order(string name, decimal price, string consumer)
        {
            this.Name = name;
            this.Price = price;
            this.Consumer = consumer;
        }

        public override string ToString()
        {
            return string.Format("{{{0};{1};{2:0.00}}}", Name, Consumer, Price);
        }

        public int CompareTo(Order other)
        {
            int compareName = this.Name.CompareTo(other.Name);

            if (compareName == 0)
            {
                int compareConsumer = this.Consumer.CompareTo(other.Consumer);

                if (compareConsumer == 0)
                {
                    return this.Price.CompareTo(other.Price);
                }

                return compareConsumer;
            }

            return compareName;
        }
    }
}
