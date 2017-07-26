using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Student_groups
{ 
    public class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telephone;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private string department;

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
        }

        public string Telephone
        {
            get { return this.telephone; }
        }

        public string Email
        {
            get { return this.email; }
        }

        public List<int> Marks
        {
            get { return this.marks; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
        }

        public string Department
        {
            get { return this.department; }
        }

        public Student(string firstName, string lastName, string facultyNumber, string telephone, string email,
            List<int> marks, int groupNumber, string deparment)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.telephone = telephone;
            this.email = email;
            this.marks = marks;
            this.groupNumber = groupNumber;
            this.department = deparment;
        }
    }
}
