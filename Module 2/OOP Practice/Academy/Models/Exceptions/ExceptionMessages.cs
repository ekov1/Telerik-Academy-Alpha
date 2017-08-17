using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Exceptions
{
    public static class ExceptionMessages
    {
        public const string CourseLength = "The name of the course must be between 3 and 45 symbols!";
        public const string LecturesPerWeek = "The number of lectures per week must be between 1 and 7!";
        public const string Username = "User's username should be between 3 and 16 symbols long!";
        public const string InvalidTrack = "The provided track is not valid!";
    }
}
