using System;
using System.Linq;

public static class SelectionSort
{
    public static void Main(string[] args)
    {
        var arrSize = int.Parse(Console.ReadLine());

        var arr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        arr = arr.OrderBy(x => x).ToArray();
        //praise LINQ

        foreach (var num in arr)
        {
            Console.WriteLine(num);
        }
    }
}