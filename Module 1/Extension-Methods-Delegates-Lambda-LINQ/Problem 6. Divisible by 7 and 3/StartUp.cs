using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 21};

        numbers
            .Where(x => x % 7 == 0 || x % 3 == 0)
            .ToList()
            .ForEach(x => Console.WriteLine(x));
    }
}

