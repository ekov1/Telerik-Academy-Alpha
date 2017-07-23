using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_classes
{
    public class Class
    {
        private string textIdentifier;
        private List<Teacher> teachers;
        private List<Student> students;

        public Class(string textIdentifier)
        {
            this.textIdentifier = textIdentifier;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }
    }
}
