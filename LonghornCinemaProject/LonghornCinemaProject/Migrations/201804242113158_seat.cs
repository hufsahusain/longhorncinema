namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatID = c.Int(nullable: false, identity: true),
                        SeatName = c.String(),
                    })
                .PrimaryKey(t => t.SeatID);
            
            AlterColumn("dbo.Showtimes", "TheaterNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Showtimes", "TheaterNumber", c => c.Int(nullable: false));
            DropTable("dbo.Seats");
        }
    }
}
