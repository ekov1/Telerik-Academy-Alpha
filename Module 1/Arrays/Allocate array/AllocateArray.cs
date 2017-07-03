using System;

public static class AllocateArray
{
    public static void Main(string[] args)
    {
        var arraySize = int.Parse(Console.ReadLine());

        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine(i * 5);
        }
    }
}