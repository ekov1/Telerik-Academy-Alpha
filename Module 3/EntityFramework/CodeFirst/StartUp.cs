using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst
{
    public class StartUp
    {
        public static void Main()
        {
            var c = "1 2 3";

            var k = c.Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join("", k));
        }
    }
}
