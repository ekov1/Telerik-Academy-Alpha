using System;
using System.Linq;

public static class UnicodeCharacters
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var inputToUnicode = input
            .ToCharArray()
            .Select(x => "\\u" + ((int) x).ToString("X").PadLeft(4, '0'));

        Console.WriteLine(string.Join(string.Empty, inputToUnicode));
    }
}