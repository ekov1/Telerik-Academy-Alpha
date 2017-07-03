using System;

public static class SayHello
{
    public static void Main(string[] args)
    {
        var name = ReadName();

        PrintHelloName(name);
    }

    public static string ReadName()
    {
        var name = Console.ReadLine();

        return name;
    }

    public static void PrintHelloName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}