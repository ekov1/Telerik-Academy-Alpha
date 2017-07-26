using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_groups
{
    public static class StartUp
    {
        public static void Main(string[] args)
        {
            var sampleStudents = new List<Student>();

            sampleStudents.Add(new Student("Peter", "Iliev", "123456", "0279113557", "peter@abv.bg", new List<int> { 3, 4, 5, 6 }, 3));
            sampleStudents.Add(new Student("Stamat", "Goshov", "124567", "0879113556", "stamat@abv.bg", new List<int> { 3, 4, 5 }, 2));
            sampleStudents.Add(new Student("Pesho", "Tishov", "122567", "0879113555", "pesho@abv.bg", new List<int> { 3, 4, 5, 6, 6 }, 2));
            sampleStudents.Add(new Student("Kiril", "Dimitrov", "121567", "0879113552", "kiril@abv.bg", new List<int> { 2, 2, 3, 4, 5, 6, 6, 6 }, 1));
            sampleStudents.Add(new Student("Hristo", "Achkov", "111782", "0879113550", "icenceto@gmail.com", new List<int> { 6, 6, 6, 6, 6 }, 2));

            //Student Groups
            sampleStudents
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName)
                .ToList()
                .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
            Console.WriteLine();

            //Student Groups extensions
            sampleStudents.StudentGroups();
            Console.WriteLine();

            //Extract students by email
            sampleStudents
                .Where(student => student.Email.Contains("abv.bg"))
                .ToList()
                .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
            Console.WriteLine();

            //Extract students by phone
            sampleStudents
                .Where(student => student.Telephone.StartsWith("02"))
                .ToList()
                .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
            Console.WriteLine();

            //Extract students by marks
            sampleStudents
                .Where(student => student.Marks.Contains(6))
                .Select(student => new { fullName = student.FirstName + " " + student.LastName, marks = student.Marks })
                .ToList()
                .ForEach(student => Console.WriteLine($"{student.fullName} {string.Join(" ", student.marks)}"));
            Console.WriteLine();

            //Extract students with two marks
            sampleStudents.ExtractTwoMarks();
            Console.WriteLine();

            //Extract marks
            sampleStudents
                .Where(student => student.FacultyNumber[4] == '5' && student.FacultyNumber[5] == '6')
                .ToList()
                .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
            Console.WriteLine();

        }

        public static void StudentGroups(this List<Student> students)
        {
            students
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName)
                .ToList()
                .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
        }

        public static void ExtractTwoMarks(this List<Student> students)
        {
            students
                .Where(student => student.Marks.Count(x => x == 2) == 2)
                .ToList()
                .ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
        }
    }
}
