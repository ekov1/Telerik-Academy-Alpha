using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            list.OrderBy(x => x).ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
