using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Program
    {
        static void Main()
        {
            var combinations = GenerateWordCombinations(new string[] { "coffee", "ice-cream", "chocolate", "red" }, 2);

            combinations.ForEach(x => Console.WriteLine($"({x})"));
        }

        static public List<string> GenerateWordCombinations(string[] inputWords, int? maxWordsPerCombination = null)
        {
            var combinations = new List<string> { "" };
            GenerateWordCombinations(inputWords, "", maxWordsPerCombination ?? inputWords.Length, combinations);
            return combinations;
        }

        static private void GenerateWordCombinations(IEnumerable<string> words, string prefix, int maxWordsPerCombination, IList<string> combinations)
        {
            if (words.Count() == 0 || maxWordsPerCombination == 0)
            {
                return;
            }

            foreach (var word in words)
            {
                GenerateWordCombinations(words.Where(x => x != word), prefix + word + " ", maxWordsPerCombination - 1, combinations);
                combinations.Add(prefix + word);
            }
        }
    }
}
