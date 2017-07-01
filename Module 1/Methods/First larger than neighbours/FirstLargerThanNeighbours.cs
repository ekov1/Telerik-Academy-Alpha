using System;
using System.Linq;

public static class FirstLargerThanNeighbours
{
    public static void Main(string[] args)
    {
        var numbersCount = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(FirstNumberLargerThanTheirNeighbours(numbers));
    }

    public static int FirstNumberLargerThanTheirNeighbours(int[] numbers)
    {
        if (numbers.Length < 3)
        {
            return -1;
        }
        else
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}