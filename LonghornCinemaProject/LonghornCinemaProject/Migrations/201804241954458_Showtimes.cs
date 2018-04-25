namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Showtimes : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Movies", "Showtime_ShowtimeID", "dbo.Showtimes");
            //DropIndex("dbo.Movies", new[] { "Showtime_ShowtimeID" });
            //DropPrimaryKey("dbo.Customers");
            //CreateTable(
            //    "dbo.ShowtimeMovies",
            //    c => new
            //        {
            //            Showtime_ShowtimeID = c.Int(nullable: false),
            //            Movie_MovieID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.Showtime_ShowtimeID, t.Movie_MovieID })
            //    .ForeignKey("dbo.Showtimes", t => t.Showtime_ShowtimeID, cascadeDelete: true)
            //    .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
            //    .Index(t => t.Showtime_ShowtimeID)
            //    .Index(t => t.Movie_MovieID);
            
        //    AlterColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false, identity: true));
        //    AddPrimaryKey("dbo.Customers", "CustomerID");
        //    DropColumn("dbo.Movies", "Showtime_ShowtimeID");
        //}
        
        //public override void Down()
        //{
        //    AddColumn("dbo.Movies", "Showtime_ShowtimeID", c => c.Int());
        //    DropForeignKey("dbo.ShowtimeMovies", "Movie_MovieID", "dbo.Movies");
        //    DropForeignKey("dbo.ShowtimeMovies", "Showtime_ShowtimeID", "dbo.Showtimes");
        //    DropIndex("dbo.ShowtimeMovies", new[] { "Movie_MovieID" });
        //    DropIndex("dbo.ShowtimeMovies", new[] { "Showtime_ShowtimeID" });
        //    DropPrimaryKey("dbo.Customers");
        //    AlterColumn("dbo.Customers", "CustomerID", c => c.String(nullable: false, maxLength: 128));
        //    DropTable("dbo.ShowtimeMovies");
        //    AddPrimaryKey("dbo.Customers", "CustomerID");
        //    CreateIndex("dbo.Movies", "Showtime_ShowtimeID");
        //    AddForeignKey("dbo.Movies", "Showtime_ShowtimeID", "dbo.Showtimes", "ShowtimeID");
        }
    }
}
