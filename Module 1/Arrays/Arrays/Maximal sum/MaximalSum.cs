using System;
using System.Linq;

public static class MaximalSum
{
    public static void Main(string[] args)
    {
        // Read input
        int[] input = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int n = input[0];
        int m = input[1];
        int[,] matrix = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            int[] currentLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < currentLine.Length; i++)
            {
                matrix[row, i] = currentLine[i];
            }
        }

        // Find sum
        int maxSum = int.MinValue;
        int currentSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                currentSum = matrix[row, col]
                             + matrix[row, col + 1]
                             + matrix[row, col + 2]
                             + matrix[row + 1, col]
                             + matrix[row + 1, col + 1]
                             + matrix[row + 1, col + 2]
                             + matrix[row + 2, col]
                             + matrix[row + 2, col + 1]
                             + matrix[row + 2, col + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}
