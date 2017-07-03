using System;

public static class StringLength
{
    public static void Main(string[] args)
    {
        var text = Console.ReadLine();

        Console.WriteLine(text.PadRight(20, '*'));
    }
}