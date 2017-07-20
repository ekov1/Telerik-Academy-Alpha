using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        var currentPos = int.Parse(Console.ReadLine());
        var array = Console.ReadLine()
            .Split(',')
            .Select(int.Parse)
            .ToArray();

        long forward = 0;
        long backwards = 0;
        while (true)
        {
            var command = Console.ReadLine();
            if (command == "exit")
            {
                break;
            }

            var cmdArgs = command.Split(' ');
            var times = int.Parse(cmdArgs[0]);
            var direction = cmdArgs[1];
            var size = int.Parse(cmdArgs[2]);

            if (direction == "forward")
            {
                for (int i = 0; i < times; i++)
                {
                    currentPos = (currentPos + size) % array.Length;

                    forward += array[currentPos];
                }
            }
            else if (direction == "backwards")
            {
                for (int i = 0; i < times; i++)
                {
                    currentPos -= size;

                    if (currentPos < 0)
                    {

                        currentPos = array.Length + currentPos % (array.Length);
                    }

                    if (currentPos >= array.Length)
                    {
                        currentPos = currentPos - array.Length;
                    }

                    backwards += array[currentPos];
                }
            }
        }

        Console.WriteLine("Forward: {0}", forward);
        Console.WriteLine("Backwards: {0}", backwards);
    }
}