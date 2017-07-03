using System;
using System.Collections.Generic;
using System.Linq;

public static class AddingPolynomials
{
    public static void Main(string[] args)
    {
        var arrSizes = int.Parse(Console.ReadLine());

        var arrOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var arrTwo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var result = string.Join(" ", SumPolynomials(arrOne, arrTwo));
        {
            Console.WriteLine(result);
        }
    }

    public static List<int> SumPolynomials(int[] arrOne, int[] arrTwo)
    {
        var result = new List<int>();
        for (int i = 0; i < arrOne.Length; i++)
        {
            result.Add(arrOne[i] + arrTwo[i]);
        }

        return result;
    }
}
