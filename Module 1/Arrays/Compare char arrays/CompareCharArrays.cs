using System;
using System.Linq;

public static class CompareCharArrays
{
    public static void Main(string[] args)
    {
        var arrOne = Console.ReadLine();
        var arrTwo = Console.ReadLine();

        if (arrOne == arrTwo)
        {
            Console.WriteLine('=');
        }
        else
        {
            var array = new [] {arrOne, arrTwo};
            array = array.OrderBy(x => x, StringComparison.Ordinal).ThenBy(x => x.Length).ToArray();

            if (array[0] == arrOne)
            {
                Console.WriteLine('<');
            }
            else
            {
                Console.WriteLine('>');
            }
        }
    }
}