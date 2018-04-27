namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BhedaSetup13 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.ShowtimeMovies", "Showtime_ShowtimeID", "dbo.Showtimes");
            //DropForeignKey("dbo.ShowtimeMovies", "Movie_MovieID", "dbo.Movies");
            //DropIndex("dbo.ShowtimeMovies", new[] { "Showtime_ShowtimeID" });
            //DropIndex("dbo.ShowtimeMovies", new[] { "Movie_MovieID" });
            AddColumn("dbo.Showtimes", "Movie_MovieID", c => c.Int());
            CreateIndex("dbo.Showtimes", "Movie_MovieID");
            AddForeignKey("dbo.Showtimes", "Movie_MovieID", "dbo.Movies", "MovieID");
            //DropTable("dbo.ShowtimeMovies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ShowtimeMovies",
                c => new
                    {
                        Showtime_ShowtimeID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Showtime_ShowtimeID, t.Movie_MovieID });
            
            DropForeignKey("dbo.Showtimes", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.Showtimes", new[] { "Movie_MovieID" });
            DropColumn("dbo.Showtimes", "Movie_MovieID");
            CreateIndex("dbo.ShowtimeMovies", "Movie_MovieID");
            CreateIndex("dbo.ShowtimeMovies", "Showtime_ShowtimeID");
            AddForeignKey("dbo.ShowtimeMovies", "Movie_MovieID", "dbo.Movies", "MovieID", cascadeDelete: true);
            AddForeignKey("dbo.ShowtimeMovies", "Showtime_ShowtimeID", "dbo.Showtimes", "ShowtimeID", cascadeDelete: true);
        }
    }
}
