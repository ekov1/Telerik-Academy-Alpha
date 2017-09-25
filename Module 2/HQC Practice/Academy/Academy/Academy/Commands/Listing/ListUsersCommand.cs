using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Core.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy.Commands.Listing
{
    public class ListUsersCommand : ICommand
    {
<<<<<<< HEAD:Module 2/HQC Practice/Academy/After/Academy/Commands/Listing/ListUsersCommand.cs
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;
        private readonly IDatabase database;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine, IDatabase database)
        {
            this.factory = factory;
            this.engine = engine;
=======
        private readonly IDatabase database;

        public ListUsersCommand(IDatabase database)
        {
>>>>>>> 537b4cd2491cdda53dfdfcca7e640bc1550ab24c:Module 2/HQC Practice/Academy/Academy/Academy/Commands/Listing/ListUsersCommand.cs
            this.database = database;
        }

        public string Execute(IList<string> parameters)
        {
            var builder = new StringBuilder();
            var trainers = this.database.Trainers;
            var students = this.database.Students;

            if (trainers.Any())
            {
                foreach (var trainer in trainers)
                {
                    builder.AppendLine(trainer.ToString());
                }
            }

            if (students.Any())
            {
                foreach (var student in students)
                {
                    builder.AppendLine(student.ToString());
                }
            }

            if (builder.ToString().Equals(""))
            {
                return "There are no registered users!";
            }

            return builder.ToString().TrimEnd();
        }
    }
}
