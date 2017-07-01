using System;
using System.Collections.Generic;
using System.Linq;

public static class CompareCharArrays
{
    public static void Main(string[] args)
    {
        var firstArray = Console.ReadLine();
        var secondArray = Console.ReadLine();

        int maxLenght;
        int smallerArray = 0;
        if (firstArray.Length <= secondArray.Length)
        {
            maxLenght = firstArray.Length;
        }
        else
        {
            maxLenght = secondArray.Length;
        }

        for (int i = 0; i < maxLenght; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                smallerArray = 1;
                break;
            }
            else if (firstArray[i] > secondArray[i])
            {
                smallerArray = 2;
                break;
            }
        }

        if (smallerArray == 1)
        {
            Console.WriteLine("<");
        }
        else if (smallerArray == 2)
        {
            Console.WriteLine(">");
        }
        else
        {
            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}