using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class Program
    {
        public static void Main()
        {
            var n = 3;
            var intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = i + 1;
            }

            GenerateHeapPermutations(n, intArray);
        }

        public static void GenerateHeapPermutations(int n, int[] intArray)
        {
            if (n == 1)
            {
                Console.WriteLine(string.Join(" ", intArray));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    GenerateHeapPermutations(n - 1, intArray);

                    int indexToSwapWithLast = (n % 2 == 0 ? i : 0);
                    // swap the positions of two characters
                    var temp = intArray[indexToSwapWithLast];
                    intArray[indexToSwapWithLast] = intArray[n - 1];
                    intArray[n - 1] = temp;
                }
            }
        }
    }
}
