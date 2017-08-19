using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinarySearch
    {
        public static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(arr.SearchBinary(0, 1, 9));
        }

        public static object SearchBinary(this IList<int> arr, int key, int min, int max)
        {
            if (min > max)
            {

                return "Nil";

            }

            int mid = (min + max) / 2;

            if (key.Equals(arr[mid]))
            {

                return ++mid;

            }

            if (key < arr[mid])
            {
                return SearchBinary(arr, key, min, mid - 1);
            }

            return SearchBinary(arr, key, mid + 1, max);
        }
    }
}
