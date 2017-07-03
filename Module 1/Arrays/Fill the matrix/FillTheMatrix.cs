using System;


public static class FillTheMatrix
{
    public static void Main(string[] args)
    {
        var dimensions = int.Parse(Console.ReadLine());
        var letter = char.Parse(Console.ReadLine());

        var matrix = new int[dimensions, dimensions];

        switch (letter)
        {
            case 'a':
                letterA(dimensions, matrix);
                break;

            case 'b':
                letterB(dimensions, matrix);
                break;

            case 'c':
                letterC(dimensions, matrix);
                break;

            case 'd':
                letterD(dimensions, matrix);
                break;
        }

        printMatrix(dimensions, matrix);

    }

    //a
    public static void letterA(int dimensions, int[,] matrix)
    {
        var counter = 1;

        for (int x = 0; x < dimensions; x++)
        {
            for (int y = 0; y < dimensions; y++)
            {
                matrix[y, x] = counter;
                counter++;
            }
        }
    }

    //b
    public static void letterB(int dimensions, int[,] matrix)
    {
        var counter = 1;
        var direction = "down";

        for (int x = 0; x < dimensions; x++)
        {
            if (direction == "down")
            {
                for (int y = 0; y < dimensions; y++)
                {
                    matrix[y, x] = counter;
                    counter++;
                }

                direction = "up";
            }
            else if (direction == "up")
            {
                for (int y = dimensions - 1; y >= 0; y--)
                {
                    matrix[y, x] = counter;
                    counter++;
                }

                direction = "down";
            }
        }
    }

    //c
    public static void letterC(int dimensions, int[,] matrix)
    {
        var counter = 1;
        var currentDiagonalElements = 1;
        var diagonalX = 0;
        var diagonalY = 0;

        //first half
        for (int diagonals = dimensions - 1; diagonals >= 0; diagonals--)
        {
            diagonalX = diagonals;
            diagonalY = 0;

            for (int diagonalElements = 0; diagonalElements < currentDiagonalElements; diagonalElements++)
            {
                matrix[diagonalX, diagonalY] = counter;
                counter++;
                diagonalX++;
                diagonalY++;
            }

            currentDiagonalElements++;
        }

        //secondhalf
        for (int diagonals = 1; diagonals < dimensions; diagonals++)
        {
            diagonalY = diagonals;
            diagonalX = 0;

            currentDiagonalElements--;

            for (int diagonalElments = 0; diagonalElments < currentDiagonalElements - 1; diagonalElments++)
            {
                matrix[diagonalX, diagonalY] = counter;
                counter++;
                diagonalX++;
                diagonalY++;
            }
        }
    }

    //d
    public static void letterD(int dimensions, int[,] matrix)
    {
        var direction = "Down";
        var n = dimensions;
        var row = 0;
        var col = 0;
        for (int i = 1; i <= n * n; i++)
        {
            switch (direction)
            {
                case "Down":
                    if (row > n - 1 || matrix[row, col] != 0)
                    {
                        direction = "Right";
                        row--;
                        col++;
                    }
                    break;

                case "Right":
                    if (col > n - 1 || matrix[row, col] != 0)
                    {
                        direction = "Up";
                        col--;
                        row--;
                    }
                    break;

                case "Up":
                    if (row < 0 || matrix[row, col] != 0)
                    {
                        direction = "Left";
                        row++;
                        col--;
                    }
                    break;

                case "Left":
                    {
                        if (col < 0 || matrix[row, col] != 0)
                        {
                            direction = "Down";
                            col++;
                            row++;
                        }
                    }
                    break;
            }

            matrix[row, col] = i;

            switch (direction)
            {
                case "Down": row++; break;
                case "Right": col++; break;
                case "Up": row--; break;
                case "Left": col--; break;
            }
        }
    }

    //print
    public static void printMatrix(int dimensions, int[,] matrix)
    {
        for (int x = 0; x < dimensions; x++)
        {
            for (int y = 0; y < dimensions; y++)
            {
                if (y == dimensions - 1)
                {
                    Console.Write("{0}", matrix[x, y]);
                }
                else
                {
                    Console.Write("{0} ", matrix[x, y]);
                }
            }

            Console.WriteLine();
        }
    }
}