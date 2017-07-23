using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public abstract class Cat : Animal, ISound
    {
        public void Sound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
