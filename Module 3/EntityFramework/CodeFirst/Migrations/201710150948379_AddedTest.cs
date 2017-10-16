namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTest : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.StudentCourses", newName: "CourseStudents");
            DropPrimaryKey("dbo.CourseStudents");
            AddPrimaryKey("dbo.CourseStudents", new[] { "Course_CourseId", "Student_StudentId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CourseStudents");
            AddPrimaryKey("dbo.CourseStudents", new[] { "Student_StudentId", "Course_CourseId" });
            RenameTable(name: "dbo.CourseStudents", newName: "StudentCourses");
        }
    }
}
