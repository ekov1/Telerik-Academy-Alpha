using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public class Student
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    public static void Main(string[] args)
    {
        var students = new List<Student>();
        students.Add(new Student("Pesho", "Peshov"));
        students.Add(new Student("Tisho", "Toshov"));
        students.Add(new Student("Kirox", "Kirov"));
        students.Add(new Student("a", "b"));
        students.Add(new Student("b", "a"));

        students.Select(x => string.Compare(x.FirstName, x.LastName))
            .Select(x => x >= 0 ? "Last Name" : "First Name")
            .ToList()
            .ForEach(x => Console.WriteLine(x));
    }
}

