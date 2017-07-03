using System;

public class MaxSum
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        int max = 0;
        int temp = 0;

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            temp = Math.Max(arr[i], temp + arr[i]);
            if (temp > max)
            {
                max = temp;
            }
        }

        Console.Write(max);
    }
}