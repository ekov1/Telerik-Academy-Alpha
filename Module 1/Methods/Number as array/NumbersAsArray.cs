using System;
using System.Linq;

public static class NumbersAsArray
{
    public static void Main(string[] args)
    {
        var arraySizes = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var biggerLength = arraySizes.Max();

        var arrayOne = new int[biggerLength + 1];
        var arrayTwo = new int[biggerLength + 1];

        var inputArrayOne = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var inputArrayTwo = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < arraySizes[0]; i++)
        {
            arrayOne[i] = inputArrayOne[i];
        }

        for (int i = 0; i < arraySizes[1]; i++)
        {
            arrayTwo[i] = inputArrayTwo[i];
        }

        for (int i = 0; i < biggerLength; i++)
        {
            var numberToAdd = (arrayOne[i] + arrayTwo[i]) % 10;
            var reminder = (arrayOne[i] + arrayTwo[i]) / 10;

            arrayOne[i] = numberToAdd;
            arrayOne[i + 1] += reminder;
        }

        var result = string.Join(string.Empty, arrayOne);
        result = result.TrimEnd('0');

        Console.WriteLine(string.Join(" ", result.ToCharArray()));
    }
}