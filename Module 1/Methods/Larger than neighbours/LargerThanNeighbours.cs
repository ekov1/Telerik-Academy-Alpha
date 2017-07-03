using System;
using System.Linq;

public static class LargerThanNeighbours
{
    public static void Main(string[] args)
    {
        var numbersCount = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(NumbersLargerThanTheirNeighbours(numbers));
    }

    public static int NumbersLargerThanTheirNeighbours(int[] numbers)
    {
        if (numbers.Length < 3)
        {
            return 0;
        }
        else
        {
            var counter = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}