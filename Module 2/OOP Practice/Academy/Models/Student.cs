using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private string username;
        private Track track;
        private IList<ICourseResult> courseResults;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public Track Track
        {
            get { return this.track; }
            set { this.track = value; }
        }

        public IList<ICourseResult> CourseResults
        {
            get { return this.courseResults; }
            set { this.courseResults = value; }
        }

        public Student(string username, string track)
        {
            this.Username = username;

            this.Track = (Track) Enum.Parse(typeof(Track), track);
        }
    }
}
