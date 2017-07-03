using System;

public static class SubstringInText
{
    public static void Main(string[] args)
    {
        var substringToMatch = Console.ReadLine().ToLower();
        var text = Console.ReadLine().ToLower();

        if (substringToMatch.Length > text.Length)
        {
            Console.WriteLine(0);
        }
        else if (substringToMatch == text)
        {
            Console.WriteLine(1);
        }
        else
        {
            var isMatch = true;
            var counter = 0;
            for (int i = 0; i < text.Length - substringToMatch.Length + 1; i++)
            {
                for (int k = 0; k < substringToMatch.Length; k++)
                {
                    if (text[i + k] != substringToMatch[k])
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                {
                    counter++;
                }
                isMatch = true;
            }

            Console.WriteLine(counter);
        }
    }
}