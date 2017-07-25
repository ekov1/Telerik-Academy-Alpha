using System;
using System.Text;

public static class StartUp
{
    static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
    {
        return new StringBuilder(str.ToString(startIndex, length));
    }

    public static void Main()
    {
        Console.WriteLine(new StringBuilder("0123456789").Substring(4, 3));
    }
}
