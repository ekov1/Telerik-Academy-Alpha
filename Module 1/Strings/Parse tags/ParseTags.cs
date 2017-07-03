using System;
using System.Text.RegularExpressions;

public static class ParseTags
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();

        var upper = text.Split(new[] { "</upcase>", "<upcase>" }, StringSplitOptions.None);

        for (int i = 0; i < upper.Length; i++)
        {
            Console.WriteLine(upper[i]);
        }
        for (int i = 1; i < upper.Length; i += 2)
        {
            upper[i] = upper[i].ToUpper();
        }

        Console.WriteLine(string.Join("", upper));
    }
}