using System;
using System.Text;

public static class SeriesOfLetters
{
    public static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            var letter = text[i];

            if (char.IsLetter(letter))
            {
                result.Append(letter);
                while (i < text.Length && letter == text[i])
                {
                    i++;
                }
                i--;
            }
        }


        Console.WriteLine(result);
    }
}