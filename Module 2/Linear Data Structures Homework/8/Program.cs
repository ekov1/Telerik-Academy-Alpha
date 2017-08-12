using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            List<int> sequence = array.ToList();

            sequence.Sort();
            int majorant = sequence[0];
            int count = 1;
            bool found = false;
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] == majorant)
                {
                    count++;
                }
                else
                {
                    if (count > sequence.Count / 2)
                    {
                        found = true;
                        break;
                    }
                    else if (i > sequence.Count / 2)
                    {
                        break;
                    }
                    else
                    {
                        count = 1;
                        majorant = sequence[i];
                    }
                }
            }

            if (found)
            {
                Console.WriteLine(majorant);
            }
            else
            {
                Console.WriteLine("No majorant");
            }
        }
    }
}
