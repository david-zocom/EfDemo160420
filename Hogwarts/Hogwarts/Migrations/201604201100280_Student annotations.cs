namespace Hogwarts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Studentannotations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "StudentTable");
            RenameColumn(table: "dbo.StudentTable", name: "Name", newName: "StudentName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.StudentTable", name: "StudentName", newName: "Name");
            RenameTable(name: "dbo.StudentTable", newName: "Students");
        }
    }
}
