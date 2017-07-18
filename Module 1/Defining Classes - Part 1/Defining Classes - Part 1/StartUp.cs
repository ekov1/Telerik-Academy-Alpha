using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        try
        {
            var Engine = new Engine();
            Engine.AddInput();
            Engine.PrintPhones();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
