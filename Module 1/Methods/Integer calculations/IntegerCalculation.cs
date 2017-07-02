using System;
using System.Linq;

public static class IntegerCalculation
{
    public static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(Min(numbers));
        Console.WriteLine(Max(numbers));
        Console.WriteLine("{0:0.00}", Average(numbers));
        Console.WriteLine(Sum(numbers));
        Console.WriteLine(Product(numbers));
    }

    public static int Min(int[] numbers)
    {
        return numbers.Min();
    }

    public static int Max(int[] numbers)
    {
        return numbers.Max();
    }

    public static double Average(int[] numbers)
    {
        return numbers.Average();
    }

    public static int Sum(int[] numbers)
    {
        return numbers.Sum();
    }

    public static long Product(int[] numbers)
    {
        long result = 1;

        foreach (var number in numbers)
        {
            result *= number;
        }

        return result;
    }
}