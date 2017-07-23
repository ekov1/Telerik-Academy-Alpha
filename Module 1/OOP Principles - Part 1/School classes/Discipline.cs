using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_classes
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.NumberOfExcercises;
            }
            set
            {
                this.numberOfExcercises = value;
            }
        }
    }
}
