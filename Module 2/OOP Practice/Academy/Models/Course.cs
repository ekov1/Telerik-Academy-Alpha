using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Academy.Models.Contracts;

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
            set { this.endingDate = value; }
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
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
        }

        public override string ToString()
        {
            return "xd";
        }
    }
}
