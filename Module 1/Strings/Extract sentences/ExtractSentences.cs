using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class ExtractSentences
{
    public static void Main(string[] args)
    {
        var keyword = Console.ReadLine();
        var sentence = Console.ReadLine();

        var matcher = new Regex(@"[A-Z].+?\.");
        var matcherKeyword = new Regex(@"\W");
        var matches = matcher.Matches(sentence);

        var result = new StringBuilder();
        foreach (Match match in matches)
        {
            if (matcherKeyword.Split(match.ToString()).ToArray().Contains(keyword))
            {
                result.Append(match);
                result.Append(' ');
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}