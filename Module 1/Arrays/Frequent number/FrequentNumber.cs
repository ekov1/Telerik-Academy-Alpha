using System;
using System.Collections.Generic;
using System.Linq;

public static class FrequentNumber
{
    static void Main(string[] args)
    {
        var arraySize = int.Parse(Console.ReadLine());

        var list = new List<int>();
        for (int i = 0; i < arraySize; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        var distinctArray = list.Distinct();
        var dictionary = new Dictionary<int, int>();

        foreach (var distinctNumber in distinctArray)
        {
            dictionary.Add(distinctNumber, list.Count(x => x == distinctNumber));
        }

        var max = dictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

        Console.WriteLine("{0} ({1} times)", max, dictionary[max]);
    }
}