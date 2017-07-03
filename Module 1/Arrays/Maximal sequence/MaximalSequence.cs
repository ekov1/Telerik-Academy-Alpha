using System;

public static class MaximalSequence
{
    public static void Main(string[] args)
    {
        var arrSize = int.Parse(Console.ReadLine());

        if (arrSize == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            var arr = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            var bestSequence = 1;
            var currentSequence = 1;
            for (int i = 0; i < arrSize - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }

                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                }
            }

            Console.WriteLine(bestSequence);
        }
    }
}