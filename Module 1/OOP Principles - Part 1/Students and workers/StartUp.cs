using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_workers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student("Goshi", "Peshov", 6));
            students.Add(new Student("Gosha", "Peshov", 6));
            students.Add(new Student("Goshu", "Peshov", 5));
            students.Add(new Student("Gosho", "Peshov", 5));
            students.Add(new Student("Goshka", "Peshov", 5));
            students.Add(new Student("Goshito", "Peshov", 5));
            students.Add(new Student("Goshna", "Peshov", 4));
            students.Add(new Student("Goshira", "Peshov", 4));
            students.Add(new Student("Goshaja", "Peshov", 3));
            students.Add(new Student("Goshania", "Peshov", 2));

            foreach (var student in students.OrderBy(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Grade}");
            }

            var workers = new List<Worker>();
            workers.Add(new Worker("Tishka", "Tishkov", 800, 8));
            workers.Add(new Worker("Tishi", "Tishkov", 900, 8));
            workers.Add(new Worker("Tisho", "Tishkov", 1200, 4));
            workers.Add(new Worker("Tisha", "Tishkov", 300, 3));
            workers.Add(new Worker("Tishon", "Tishkov", 1200, 8));
            workers.Add(new Worker("Tishara", "Tishkov", 3300, 12));
            workers.Add(new Worker("Tishaka", "Tishkov", 4600, 16));
            workers.Add(new Worker("Tishna", "Tishkov", 1000, 8));
            workers.Add(new Worker("Tishira", "Tishkov", 21000, 8));
            workers.Add(new Worker("Tishania", "Tishkov", 100, 8));
            workers.Add(new Worker("Tishito", "Tishkov", 1000, 8));


            foreach(var worker in workers.OrderByDescending(x => x.MoneyPerHour()))
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName} {worker.MoneyPerHour()}");
            }

            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            foreach(var human in humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }
        }
    }
}
