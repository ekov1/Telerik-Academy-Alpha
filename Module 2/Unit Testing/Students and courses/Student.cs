using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students_and_courses.Interfaces;

namespace Students_and_courses
{
    public class Student : IStudent
    {
        public string Name { get; }
        public int Id { get; }

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"Name: {Name}");
            result.Append($"Id: {Id}");

            return result.ToString();
        }
    }
}
