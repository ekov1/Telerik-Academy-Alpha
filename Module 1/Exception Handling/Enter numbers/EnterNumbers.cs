using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnterNumbers
{
    public static void Main(string[] args)
    {
        var start = 1;
        var end = 100;

        var nunbers = new List<int>();
        var exceptionNotThrown = true;
        for (int i = 0; i < 10; i++)
        {
            var currentNumber = ReadNumber(start, end);

            if (currentNumber > start && currentNumber < end)
            {
                nunbers.Add(currentNumber);
                start = currentNumber;
            }
            else
            {
                exceptionNotThrown = false;      
                break;
            }
        }

        if (exceptionNotThrown)
        {
            Console.Write("1 < ");
            Console.Write(string.Join(" < ", nunbers));
            Console.Write(" < 100");
        }
        
    }

    public static int ReadNumber(int start, int end)
    {
        var number = 0;

        try
        {
            number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new Exception();
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }

        return number;
    }
}