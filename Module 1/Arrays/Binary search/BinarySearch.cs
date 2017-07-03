using System;
using System.Collections.Generic;

public static class BinarySearch
{
    public static void Main(string[] args)
    {
        var listSize = int.Parse(Console.ReadLine());

        var list = new List<int>();
        for (int i = 0; i < listSize; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        try
        {
            Console.WriteLine(list.IndexOf(int.Parse(Console.ReadLine())));
        }
        catch (Exception)
        {
            Console.WriteLine("-1");
        }
    }
}