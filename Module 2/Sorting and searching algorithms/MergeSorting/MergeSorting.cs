using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorting
{
    class MergeSorting
    {
        static void Main(string[] args)
        {
            var arr = new[] { 3, 1, 7, 6, 4, 2, 5, 9, 8 };
            Sort(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
        public static void Sort<T>(T[] a)
            where T : IComparable<T>
        {
            Sort(a, 0, a.Length);
        }

        public static void Sort<T>(T[] a, int low, int high)
            where T : IComparable<T>
        {
            int N = high - low;
            if (N <= 1)
                return;

            int mid = low + N / 2;

            Sort(a, low, mid);
            Sort(a, mid, high);

            T[] aux = new T[N];
            int i = low, j = mid;
            for (int k = 0; k < N; k++)
            {
                if (i == mid) aux[k] = a[j++];
                else if (j == high) aux[k] = a[i++];
                else if (a[j].CompareTo(a[i]) < 0) aux[k] = a[j++];
                else aux[k] = a[i++];
            }

            for (int k = 0; k < N; k++)
            {
                a[low + k] = aux[k];
            }
        }
    }
}
