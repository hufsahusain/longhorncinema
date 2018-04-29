namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerInfoUpdateHufsa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MiddleInitial", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "State", c => c.String());
            AddColumn("dbo.Customers", "Street", c => c.String());
            AddColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "SSN", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
            DropColumn("dbo.Customers", "SSN");
            DropColumn("dbo.Customers", "ZipCode");
            DropColumn("dbo.Customers", "Street");
            DropColumn("dbo.Customers", "State");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "MiddleInitial");
        }
    }
}
