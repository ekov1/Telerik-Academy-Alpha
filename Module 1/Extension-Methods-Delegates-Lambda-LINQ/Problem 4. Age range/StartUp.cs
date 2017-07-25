using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

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

        public int Age
        {
            get
            {
                return this.age;              
            }
        }

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        
    }

    public static void Main()
    {
        var students = new List<Student>();
        students.Add(new Student("Pesho", "Peshov", 10));
        students.Add(new Student("Tisho", "Toshov", 20));
        students.Add(new Student("Kirox", "Kirov", 24));
        students.Add(new Student("a", "b", 18));
        students.Add(new Student("b", "a", 25));

        students.Where(student => student.Age >= 18 && student.Age <= 24)
            .ToList()
            .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName} {student.Age}"));
    }
}

