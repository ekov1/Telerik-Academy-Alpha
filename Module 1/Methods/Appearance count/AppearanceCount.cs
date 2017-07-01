using System;
using System.Linq;

public static class AppearanceCount
{
    public static void Main(string[] args)
    {
        var arraySize = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        var numberToCount = int.Parse(Console.ReadLine());

        Console.WriteLine(CountNumber(numbers, numberToCount));
    }

    public static int CountNumber(int[] numbers, int numbersToCount)
    {
        var counter = 0;
        foreach (var number in numbers.Where(x => x == numbersToCount))
        {
            counter++;
        }

        return counter;
    }
}