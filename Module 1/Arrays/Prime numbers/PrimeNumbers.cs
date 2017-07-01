using System;

public class PrimeNumbers
{
    public static void Main(string[] args)
    {
        int arrSize = int.Parse(Console.ReadLine()) + 1;

        bool[] primeIsTrue = new bool[arrSize];

        for (int i = 2; i < arrSize; i++)
        {
            primeIsTrue[i] = true;
        }

        for (int i = 0; i < arrSize; i++)
        {
            if (primeIsTrue[i])
            {
                for (int p = 2; (p * i) < arrSize; p++)
                {
                    primeIsTrue[p * i] = false;
                }
            }
        }

        for (int i = arrSize - 1; i > 0; i--)
        {
            if (primeIsTrue[i])
            {
                Console.Write(i);
                break;
            }
        }
    }
}