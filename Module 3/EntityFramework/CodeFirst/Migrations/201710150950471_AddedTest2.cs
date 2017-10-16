namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTest2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CourseStudents", newName: "StudentCourses");
            DropPrimaryKey("dbo.StudentCourses");
            AddPrimaryKey("dbo.StudentCourses", new[] { "Student_StudentId", "Course_CourseId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.StudentCourses");
            AddPrimaryKey("dbo.StudentCourses", new[] { "Course_CourseId", "Student_StudentId" });
            RenameTable(name: "dbo.StudentCourses", newName: "CourseStudents");
        }
    }
}
