using System;

public class SquareRoot
{
    public static void Main(string[] args)
    {
        try
        {
            var number = double.Parse(Console.ReadLine());

            if (number < 0 || number > double.MaxValue)
            {
                throw new Exception();
            }

            Console.WriteLine("{0:f3}", Math.Sqrt(number));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}