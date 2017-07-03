using System;
using System.Text.RegularExpressions;

public static class SubstringInText
{
    public static void Main(string[] args)
    {
        var substringToMatch = Console.ReadLine().ToLower();
        var text = Console.ReadLine().ToLower();

        var matcher = new Regex(substringToMatch);
        var matches = matcher.Matches(text);

        var counter = 0;
        foreach (Match match in matches)
        {
            counter++;
        }

        Console.WriteLine(counter);
    }
}