﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void Sound()
        {
            Console.WriteLine("Bark!");
        }
    }
}
