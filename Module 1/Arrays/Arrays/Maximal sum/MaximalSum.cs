using System;
using System.Linq;

public static class MaximalSum
{
    public static void Main(string[] args)
    {
        var dimensions = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var x = dimensions[0];
        var y = dimensions[0];
        if (x < 3 || y < 3)
        {
            return;
        }

        var matrix = new int[x][];
        for (int i = 0; i < x; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        }

        var bestSum = int.MinValue;
        var currentSum = 0;
        for (int row = 0; row < x; row++)
        {
            for (int col = 0; col < y; col++)
            {
                try
                {
                    currentSum += matrix[row][col];

                    currentSum += matrix[row + 1][col];

                    currentSum += matrix[row][col + 1];

                    currentSum += matrix[row - 1][col];

                    currentSum += matrix[row][col - 1];

                    currentSum += matrix[row + 1][col + 1];

                    currentSum += matrix[row - 1][col - 1];

                    currentSum += matrix[row + 1][col - 1];

                    currentSum += matrix[row - 1][col + 1];
                }
                catch (Exception)
                {
                    currentSum = 0;
                    continue;
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                }

                currentSum = 0;
            }
        }

        Console.WriteLine(bestSum);
    }
}