using System;
using System.Linq;

public static class MaximalKSum
{
    public static void Main(string[] args)
    {
        var arrSize = int.Parse(Console.ReadLine());
        var elementsToTake = int.Parse(Console.ReadLine());

        var arr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        var maxSum = arr
            .OrderByDescending(x => x)
            .Take(elementsToTake)
            .Sum();
        Console.WriteLine(maxSum);
    }
}