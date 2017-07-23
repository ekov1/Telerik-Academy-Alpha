using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_workers
{
    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
        }

        public Student(string firstName, string lastName, int grade)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            this.grade = grade;
        }
    }
}
