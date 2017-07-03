using System;
using System.Linq;

public static class ReverseString
{
    public static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var result = text.ToCharArray().Reverse().ToArray();

        Console.WriteLine(result);
    }
}

