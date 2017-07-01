using System;
using System.Linq;

public static class MergeSort
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
        //I am sure there is merge sort somewhere underneath this depending on the arrays size : ^)

        foreach (var number in arr)
        {
            Console.WriteLine(number);
        }
    }
}