using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();

            animals.Add(new Kitten(3, "Stamat"));
            animals.Add(new Tomcat(4, "Pusho"));
            animals.Add(new Dog(2, "Sharo", "male"));
            animals.Add(new Frog(1, "Ribit", "Female"));
        }
    }
}
