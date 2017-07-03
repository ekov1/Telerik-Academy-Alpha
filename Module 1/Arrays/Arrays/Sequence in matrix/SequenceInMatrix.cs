using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class SequenceInMatrix
{
    public static void Main(string[] args)
    {
        var dimensions = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse).ToArray();

        var rows = dimensions[0];
        var cols = dimensions[1];

        var matrix = new string[rows, cols];

        for (int x = 0; x < rows; x++)
        {
            var line = Console.ReadLine()
                .Split(' ');

            for (int y = 0; y < cols; y++)
            {
                matrix[x, y] = line[y];
            }
        }

        var bestCount = 0;

        var currentCount = countRows(matrix, bestCount);
        if (bestCount < currentCount)
        {
            bestCount = currentCount;
        }

        currentCount = countCols(matrix, bestCount);
        if (bestCount < currentCount)
        {
            bestCount = currentCount;
        }
        
            
        

        Console.WriteLine("{0}", bestCount);
    }

    public static int countRows(string[,] matrix, int bestCount)
    {
        var currentCount = 1;
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1) - 1; y++)
            {
                if (matrix[x, y] == matrix[x, y + 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                    }

                    currentCount = 1;
                }
            }
            if (currentCount > bestCount)
            {
                bestCount = currentCount;
            }

            currentCount = 1;
        }

        return bestCount;
    }

    public static int countCols(string[,] matrix, int bestCount)
    {
        var currentCount = 1;
        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)
            {
                if (matrix[x, y] == matrix[x + 1, y])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                    }

                    currentCount = 1;
                }
            }
            if (currentCount > bestCount)
            {
                bestCount = currentCount;
            }

            currentCount = 1;
        }

        return bestCount;
    }
}