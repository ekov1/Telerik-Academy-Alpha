using System;
using System.Text;
using System.Text.RegularExpressions;

public static class ReplaceTags
{
    public static void Main(string[] args)
    {
        var text = new StringBuilder(Console.ReadLine());

        var matcher = new Regex(@"<a .*?href=""(.*?)"">(.*?)<\/a>");
        var matches = matcher.Matches(text.ToString());

        foreach (Match match in matches)
        {
            text.Replace(match.ToString(), string.Format("[{1}]({0})", match.Groups[1], match.Groups[2]));
        }

        Console.WriteLine(text);
    }
}