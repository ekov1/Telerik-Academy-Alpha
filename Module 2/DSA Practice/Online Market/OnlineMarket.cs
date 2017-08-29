using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Market
{
    public class OnlineMarket
    {
        public static void Main(string[] args)
        {
            var products = new Products();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var inputTokens = input.Split().ToArray();

                switch (inputTokens[0])
                {
                    case "add":
                        products.AddProduct(inputTokens[1], decimal.Parse(inputTokens[2]), inputTokens[3]);
                        break;

                    case "filter":
                        switch (inputTokens.Length)
                        {
                            case 4:
                                products.FilterByType(inputTokens[3]);
                                break;

                            case 5:
                                if (inputTokens[3] == "from")
                                {
                                    products.FilterFromMin(decimal.Parse(inputTokens[4]));
                                }
                                else
                                {
                                    products.FilterToMax(decimal.Parse(inputTokens[4]));
                                }
                                break;

                            case 7:
                                products.FilterFromMinToMax(decimal.Parse(inputTokens[4]), decimal.Parse(inputTokens[6]));
                                break;
                        }
                        break;
                }
            }
        }
    }

    public class Products
    {
        private Dictionary<string, SortedSet<Product>> _productsGroupedByType = new Dictionary<string, SortedSet<Product>>();
        private SortedSet<Product> _productsSortedByPrice = new SortedSet<Product>();
        private HashSet<string> _addedProducts = new HashSet<string>();

        public void AddProduct(string name, decimal price, string type)
        {
            var product = new Product(name, price, type);

            if (_addedProducts.Contains(name))
            {
                Console.WriteLine("Error: Product {0} already exists", name);
            }
            else
            {
                _addedProducts.Add(name);
                _productsSortedByPrice.Add(product);

                if (!_productsGroupedByType.ContainsKey(type))
                {
                    _productsGroupedByType.Add(type, new SortedSet<Product>());
                }
                _productsGroupedByType[type].Add(product);

                Console.WriteLine("Ok: Product {0} added successfully", name);
            }
        }

        public void FilterByType(string type)
        {
            if (!_productsGroupedByType.ContainsKey(type))
            {
                Console.WriteLine("Error: Type {0} does not exists", type);
            }
            else
            {
                Console.WriteLine("Ok: {0}", string.Join(", ", _productsGroupedByType[type].Take(10)));
            }
        }

        public void FilterFromMinToMax(decimal min, decimal max)
        {
            Console.WriteLine("Ok: {0}", string.Join(", ", _productsSortedByPrice.Where(x => x.Price >= min && x.Price <= max).Take(10)));
        }

        public void FilterFromMin(decimal min)
        {
            Console.WriteLine("Ok: {0}", string.Join(", ", _productsSortedByPrice.Where(x => x.Price >= min).Take(10)));
        }

        public void FilterToMax(decimal max)
        {
            Console.WriteLine("Ok: {0}", string.Join(", ", _productsSortedByPrice.Where(x => x.Price <= max).Take(10)));
        }
    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public Product(string name, decimal price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public int CompareTo(Product other)
        {
            var result = this.Price.CompareTo(other.Price);


            if (result == 0)
            {
                result = 1;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1:G29})", this.Name, this.Price);
        }
    }
}