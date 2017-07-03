using System;
using System.Linq;

public static class BishopPathFinder
{
    public static void Main(string[] args)
    {
        var boardSizeInput = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var numberOfCommands = int.Parse(Console.ReadLine());
        var commands = new string[numberOfCommands];
        for (int i = 0; i < numberOfCommands; i++)
        {
            commands[i] = Console.ReadLine();
        }

        var filledBoard = FilledBoard(boardSizeInput);

        //PrintBoard(filledBoard);

        var result = CommandsExecuter(filledBoard, commands);
        Console.WriteLine(result);
    }

    public static int[,] FilledBoard(int[] boardSize)
    {
        var boardRows = boardSize[0];
        var boardCols = boardSize[1];
        var board = new int[boardRows, boardCols];

        var currentStartingValue = 0;

        for (int x = boardRows - 1; x >= 0; x--)
        {
            var currentValue = currentStartingValue;
            for (int y = 0; y < boardCols; y++)
            {
                board[x, y] = currentValue;
                currentValue += 3;
            }

            currentStartingValue += 3;
        }

        return board;
    }

    public static void PrintBoard(int[,] board)
    {
        for (int x = 0; x < board.GetLength(0); x++)
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                Console.Write("{0} ", board[x, y]);
            }
            Console.WriteLine();
        }
    }

    public static int CommandsExecuter(int[,] board, string[] commands)
    {
        var totalSum = 0;
        var currentRow = board.GetLength(0) - 1;
        var currentCol = 0;

        var wasThere = new bool[board.GetLength(0), board.GetLength(1)];

        foreach (var command in commands)
        {
            var tokens = command.Split(' ');

            var direction = tokens[0];
            var movement = int.Parse(tokens[1]);

            for (int i = 0; i < movement - 1; i++)
            {
                wasThere[currentRow, currentCol] = true;

                if (direction == "UR" || direction == "RU")
                {
                    if (currentRow != 0 && currentCol != board.GetLength(1) - 1)
                    {
                        currentRow--;
                        currentCol++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (direction == "LU" || direction == "UL")
                {
                    if (currentRow != 0 && currentCol != 0)
                    {
                        currentRow--;
                        currentCol--;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (direction == "DL" || direction == "LD")
                {
                    if (currentRow != board.GetLength(0) - 1 && currentCol != 0)
                    {
                        currentRow++;
                        currentCol--;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (direction == "DR" || direction == "RD")
                {
                    if (currentRow != board.GetLength(0) - 1 && currentCol != board.GetLength(1) - 1)
                    {
                        currentRow++;
                        currentCol++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (!wasThere[currentRow, currentCol])
                {
                    totalSum += board[currentRow, currentCol];
                }
            }
        }

        return totalSum;
    }
}