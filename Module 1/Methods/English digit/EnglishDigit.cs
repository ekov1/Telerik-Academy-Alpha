using System;
using System.Linq;

public static class EnglishDigit
{
    public static void Main(string[] args)
    {
        var number = Console.ReadLine();

        var lastDigit = ExtractLastDigit(number);
        var result = LastDigitToString(lastDigit);

        Console.WriteLine(result);
    }

    public static int ExtractLastDigit(string number)
    {
        return int.Parse(number.Last().ToString());
    }

    public static string LastDigitToString(int lastDigit)
    {
        switch (lastDigit)
        {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
        }

        return string.Empty;
    }
}