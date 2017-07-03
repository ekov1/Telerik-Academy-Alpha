using System;

public static class CompareArrays
{
    public static void Main(string[] args)
    {
        var arraySize = int.Parse(Console.ReadLine());
        var array = new int[arraySize];
        var isEqual = true;

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize; i++)
        {
            if (array[i] != int.Parse(Console.ReadLine()))
            {
                isEqual = false;
                break;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}