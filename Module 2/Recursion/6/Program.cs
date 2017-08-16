using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var words = new string[] {"dog", "cat", "fish", "crocodile"};

            PrintSubSetOfStrings(words, 0);
        }

        private static void PrintSubSetOfStrings(string[] words, int k)
        {
            if (k == words.Length - 1)
            {
                return;
            }

            for (int j = k; j < words.Length - 1; j++)
            {
                Console.WriteLine($"{words[k]} {words[j +  1]}");
            }

            PrintSubSetOfStrings(words, k + 1);
        }
    }
}
