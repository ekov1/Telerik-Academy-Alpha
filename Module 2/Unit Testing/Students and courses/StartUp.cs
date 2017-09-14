using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_courses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var student = new Student("Icka", 23423432);
            var course = new Course();

            for (int i = 0; i < 31; i++)
            {
                course.Add(student);
            }

            Console.WriteLine(course.ToString());
        }
    }
}
