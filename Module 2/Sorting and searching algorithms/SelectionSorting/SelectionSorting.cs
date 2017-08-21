using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSorting
{
    public static class SelectionSorting
    {
        public static void Main(string[] args)
        {
            var arr = new[] {3, 1, 7, 6, 4, 2, 5, 9, 8};

            arr.SelectionSort();

            Console.WriteLine(string.Join(" ", arr));
        }

        public static IList SelectionSort(this int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int iMin = j;

                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[iMin])
                    {
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    int k = arr[j];
                    arr[j] = arr[iMin];
                    arr[iMin] = k;
                }
            }

            return arr;
        }
    }
}
