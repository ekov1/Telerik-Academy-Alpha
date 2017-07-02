using System;
using System.Numerics;

public static class NFactorial
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(n));
    }

    public static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i < n; i++)
        {
            result += result * i;
        }

        return result;
    }
}