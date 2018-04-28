namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BhedaSetup17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenreName");
        }
    }
}
