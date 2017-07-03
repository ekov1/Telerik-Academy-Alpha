using System;
using System.Collections.Generic;

public static class CorrectBrackets
{
    public static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var textToArr = text.ToCharArray();

        var brackets = new Stack<char>();
        var exception = false;
        foreach (var c in textToArr)
        {
            try
            {
                if (c == '(')
                {
                    brackets.Push(c);
                }
                else if (c == ')')
                {
                    brackets.Pop();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect");
                exception = true;
                break;
            }
        }

        if (brackets.Count == 0 && !exception)
        {
            Console.WriteLine("Correct");
        }
        else if(!exception)
        {
            Console.WriteLine("Incorrect");
        }
    }
}