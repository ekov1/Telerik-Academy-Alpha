using System;
using System.Linq;

public static class QuickSort
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
        //nobody got time for dat

        foreach (var number in arr)
        {
            Console.WriteLine(number);
        }
    }
}