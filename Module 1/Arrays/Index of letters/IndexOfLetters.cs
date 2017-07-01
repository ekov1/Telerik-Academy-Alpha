using System;

public static class IndexOfLetters
{
    public static void Main(string[] args)
    {
        var word = Console.ReadLine();

        foreach(var c in word)
        {
            Console.WriteLine(c - 97);
        }
    }
}