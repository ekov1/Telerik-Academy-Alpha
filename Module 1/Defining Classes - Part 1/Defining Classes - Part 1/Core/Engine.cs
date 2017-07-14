using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private GSMTest test = new GSMTest();

    public void AddInput()
    {
        while (true)
        {
            Console.WriteLine(@"Enter general phone specs seperated by space or ""End"" to stop:");
            var input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }
            var inputsArgs = input.Split(' ');

            try
            {
                if (inputsArgs.Length < 2)
                {
                    throw new IndexOutOfRangeException("Invalid input!");
                }
                else if (inputsArgs.Length == 2)
                {
                    var model = inputsArgs[0];
                    var manufacturer = inputsArgs[1];
                    GSM phone = new GSM(model, manufacturer);

                    test.AddPhone(phone);
                }
                else if (inputsArgs.Length == 3)
                {
                    var model = inputsArgs[0];
                    var manufacturer = inputsArgs[1];
                    var price = decimal.Parse(inputsArgs[2]);
                    GSM phone = new GSM(model, manufacturer, price);

                    test.AddPhone(phone);
                }
                else if (inputsArgs.Length == 4)
                {
                    var model = inputsArgs[0];
                    var manufacturer = inputsArgs[1];
                    var price = decimal.Parse(inputsArgs[2]);
                    var owner = inputsArgs[3];
                    GSM phone = new GSM(model, manufacturer, price, owner);

                    test.AddPhone(phone);
                }


                Console.WriteLine(@"Enter battery specs seperated by space or ""End"" to stop:");


            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException("Invalid Input!");
            }
        }
    }

    public void PrintPhones()
    {
        foreach (var phone in test.Phones )
        {
            Console.WriteLine(phone.ToString());
        }
    }
}

