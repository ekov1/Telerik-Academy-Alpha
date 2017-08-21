using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    public static class Shuffle
    {
        public static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(string.Join(" ", arr.ShuffleArray()));
        }

        public static int[] ShuffleArray(this IList<int> arr)
        {
            return arr.OrderBy(x => Guid.NewGuid()).ToArray();
        }
    }
}
