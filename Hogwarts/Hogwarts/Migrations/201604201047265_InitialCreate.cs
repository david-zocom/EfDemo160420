namespace Hogwarts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentNumber = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.StudentNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
