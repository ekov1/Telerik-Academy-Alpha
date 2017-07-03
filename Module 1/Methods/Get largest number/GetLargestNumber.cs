using System;
using System.Linq;

public static class GetLargestNumber
{
    public static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(GetMax(numbers));
    }

    public static int GetMax(int[] numbers)
    {
        return numbers.Max();
    }
}