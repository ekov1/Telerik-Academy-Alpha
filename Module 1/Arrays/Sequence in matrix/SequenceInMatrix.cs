using System;
using System.Linq;

public static class SequenceInMatrix
{
    public static void Main(string[] args)
    {
        var matrixDimension = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var x = matrixDimension[0];
        var y = matrixDimension[1];

        var matrix = new string[x, y];
        for (int row = 0; row < x; row++)
        {
            var arr = Console.ReadLine().Split(' ');
            for (int col = 0; col < y; col++)
            {
                matrix[row, col] = arr[col];
            }
        }

        var bestSum = 1;

        var currentSum = bestRow(matrix);
        if (currentSum > bestSum)
        {
            bestSum = currentSum;
        }

        currentSum = bestCol(matrix);
        if (currentSum > bestSum)
        {
            bestSum = currentSum;
        }

        Console.WriteLine(bestSum);
    }

    public static int bestRow(string[,] matrix)
    {
        var bestSumRow = 1;
        var currentSumRow = 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSumRow++;
                }
                else
                {
                    currentSumRow = 1;
                }

                if (currentSumRow > bestSumRow)
                {
                    bestSumRow = currentSumRow;
                }
            }

            currentSumRow = 1;
        }

        return bestSumRow;
    }

    public static int bestCol(string[,] matrix)
    {
        var bestSumCol = 1;
        var currentSumCol = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSumCol++;
                }
                else
                {
                    currentSumCol = 1;
                }

                if (currentSumCol > bestSumCol)
                {
                    bestSumCol = currentSumCol;
                }
            }

            currentSumCol = 1;
        }

        return bestSumCol;
    }
}