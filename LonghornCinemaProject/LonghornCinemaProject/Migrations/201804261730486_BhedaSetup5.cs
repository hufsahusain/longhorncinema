namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BhedaSetup5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Quantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Quantity");
        }
    }
}
