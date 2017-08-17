using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Academy.Models.Contracts;
using Academy.Models.Exceptions;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private IList<IStudent> onsiteStudents;
        private IList<IStudent> onlineStudents;
        private IList<ILecture> lectures;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int LecturesPerWeek
        {
            get { return this.lecturesPerWeek; }
            set { this.lecturesPerWeek = value; }
        }

        public DateTime StartingDate
        {
            get { return this.startingDate; }
            set { this.startingDate = value; }
        }

        public DateTime EndingDate
        {
            get { return this.endingDate; }
            set { this.endingDate = value.AddDays(30); }
        }

        public IList<IStudent> OnsiteStudents
        {
            get { return this.onsiteStudents; }
            set { this.onsiteStudents = value; }
        }

        public IList<IStudent> OnlineStudents
        {
            get { return this.onlineStudents; }
            set { this.onlineStudents = value; }
        }

        public IList<ILecture> Lectures
        {
            get { return this.lectures; }
            set { this.lectures = value; }
        }

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            //name
            if (name.Length < 3 || name.Length > 45)
            {
                throw new ArgumentException(ExceptionMessages.CourseLength);
            }
            this.name = name;

            //lecturesPerWeek
            int value;
            bool successfullyParsed = int.TryParse(lecturesPerWeek, out value);
            if (successfullyParsed && value >= 1 && value <= 7)
            {
                this.lecturesPerWeek = value;
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.LecturesPerWeek);
            }

            //startingDate
            this.startingDate = DateTime.Parse(startingDate);

            //endingDate
            this.endingDate = DateTime.Parse(startingDate).AddDays(30);

            //lectures
            this.lectures = new List<ILecture>();
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("* Course");
            result.AppendLine($" - Name: {name}");
            result.AppendLine($" - Lectures per week: {lecturesPerWeek}");
            result.AppendLine($" - Starting date: {startingDate}");
            result.AppendLine($" - Ending date: {endingDate}");
            result.AppendLine(" - Lectures:");
            if (lectures.Count == 0)
            {
                result.Append(" * There are no lectures in this course!");
            }
            else
            {
                foreach (var lecture in lectures)
                {
                    result.Append(lecture);
                }
            }

            return result.ToString();
        }
    }
}
