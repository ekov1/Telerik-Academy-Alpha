using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class RemoveElementsFromArray
{
    public static void Main(string[] args)
    {
        var sequenceCount = int.Parse(Console.ReadLine());

        var sequence = new int[sequenceCount];

        for (int i = 0; i < sequenceCount; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        var bestOutcome = 0;

        for (int i = 0; i < sequenceCount - 1; i++)
        {
            if (sequence[i] <= sequence[i + 1])
            {
                
            }
        }
    }
}

