using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        string keks = Console.ReadLine();

        StringBuilder strbrInput = new StringBuilder();

        foreach (var c in keks)
        {
            if (char.IsDigit(c))
            {
                strbrInput.Append(c);
            }
        }

        var input = strbrInput.ToString();
  

        double result = 0;
        var indexator = 0;
        for (int i = input.Length; i > 0; i--)
        {
            var number = int.Parse(input[indexator].ToString());

            if (i % 2 != 0)
            {
                result += number * Math.Pow(i, 2);
            }
            else if (i % 2 == 0)
            {
                result += Math.Pow(number, 2) * i;
            }
            indexator++;
        }

        var key = (long)result % 26;
        string strResult = string.Format("{0}", result);

        if (strResult.Last() == '0')
        {
            Console.WriteLine(strResult);
            Console.WriteLine("Big Vik wins again!");
        }
        else
        {
            Console.WriteLine(strResult);
            var strBuilder = new StringBuilder();

            var counter = 0;
            for (int i = 0; i < int.Parse(strResult.Last().ToString()); i++)
            {
                char x = (char)(65 + (key + counter) % 26);
                strBuilder.Append(x);
                counter++;
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}


