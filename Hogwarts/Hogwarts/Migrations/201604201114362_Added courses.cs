namespace Hogwarts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedcourses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseCode = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CourseCode);
            
            AddColumn("dbo.StudentTable", "CurrentCourseCode", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentTable", "CurrentCourseCode");
            AddForeignKey("dbo.StudentTable", "CurrentCourseCode", "dbo.Courses", "CourseCode", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentTable", "CurrentCourseCode", "dbo.Courses");
            DropIndex("dbo.StudentTable", new[] { "CurrentCourseCode" });
            DropColumn("dbo.StudentTable", "CurrentCourseCode");
            DropTable("dbo.Courses");
        }
    }
}
