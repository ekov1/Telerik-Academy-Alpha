using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Exceptions;
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
            //username
            if (string.IsNullOrEmpty(username) || username.Length < 2 || username.Length > 17)
            {
                throw new ArgumentException(ExceptionMessages.Username);
            }
            this.username = username;

            //track
            Track value;
            var successfullyParsed = Enum.TryParse(track, out value);
            if (successfullyParsed)
            {
                this.track = value;
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidTrack);
            }

            //courseResults
            this.courseResults = new List<ICourseResult>();
        }

        public override string ToString()
        {
           var result = new StringBuilder();

            result.AppendLine("* Student:");
            result.AppendLine($"- Username: {username}");
            result.AppendLine($"- Track: {track}");
            result.AppendLine($" Course results:");

            if (courseResults.Count == 0)
            {
                result.AppendLine(" * User has no course results!");
            }
            else
            {
                foreach (var courseResult in CourseResults)
                {
                    result.AppendLine(courseResult.ToString());
                }
            }

            return result.ToString();
        }
    }
}
