using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Bytes2you.Validation;
using Students_and_courses.Interfaces;

namespace Students_and_courses
{
    public class Course
    {


        IList<IStudent> students = new Collection<IStudent>();

        public void Add(IStudent student)
        {
            Guard.WhenArgument(students.Count, "students count").IsGreaterThan(30).Throw();
            students.Add(student);
        }

        public void Remove(IStudent student)
        {
            students.Remove(student);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var student in students)
            {
                result.AppendLine(student.ToString());
            }

            return result.ToString();
        }
    }
}
