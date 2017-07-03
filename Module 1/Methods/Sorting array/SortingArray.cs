using System;
using System.Linq;

public static class SortingArray
{
    public static void Main(string[] args)
    {
        Console.ReadLine();

        var array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(string.Join(" ", SortArray(array)));
    }

    public static int[] SortArray(int[] array)
    {
        return array.OrderBy(x => x).ToArray();
    }
}