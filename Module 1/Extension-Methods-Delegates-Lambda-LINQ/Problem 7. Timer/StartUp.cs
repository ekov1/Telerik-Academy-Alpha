using System;
using System.Threading;

public class StartUp
{
    static void SetInterval(Action f)
    {
        while (true)
        {
            Thread.Sleep(1000);

            f();
        }
    }

    static void Main()
    {
        SetInterval(new Action(() =>
            Console.WriteLine(DateTime.Now)));
    }
}

