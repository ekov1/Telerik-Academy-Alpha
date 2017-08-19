using System;
using System.Collections;

namespace LinearSearch
{
    public static class LinearSearch
    {
        public static void Main(string[] args)
        {
            var arr = new[] {'a', 'b', 'c'};

            Console.WriteLine(arr.SearchLinear('c'));
        }

        public static int SearchLinear(this IList arr,  object obj)
        {         
            for (var i = 0; i < arr.Count; i++)
            {
                if (arr[i].Equals(obj))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
