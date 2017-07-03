using System;
using System.Linq;

public static class ReverseNumber
{
    public static void Main(string[] args)
    {
        var number = Console.ReadLine();

        Console.WriteLine(ReverseNum(number));
    }

    public static string ReverseNum(string number)
    {
        return string.Join(string.Empty, number.ToCharArray().Reverse());
    }
}