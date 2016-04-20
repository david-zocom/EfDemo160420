namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedproperty3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Class1", "MyProperty3", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Class1", "MyProperty3");
        }
    }
}
