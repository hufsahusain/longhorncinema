namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReSetup : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Customers",
            //    c => new
            //        {
            //            CustomerID = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(),
            //            Password = c.String(),
            //            FirstName = c.String(),
            //            LastName = c.String(),
            //            Address = c.String(),
            //            PhoneNumber = c.Int(nullable: false),
            //            BirthDate = c.DateTime(nullable: false),
            //            CreditCard = c.Int(nullable: false),
            //            PopcornPoints = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CustomerID);
            
            //CreateTable(
            //    "dbo.Movies",
            //    c => new
            //        {
            //            MovieID = c.Int(nullable: false, identity: true),
            //            ReleaseDate = c.DateTime(nullable: false),
            //            Rating = c.String(),
            //            Tagline = c.String(),
            //            MovieCustomerRating = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Actors = c.String(),
            //            Title = c.String(),
            //            RunTime = c.Int(nullable: false),
            //            Overview = c.String(),
            //            Revenue = c.Long(nullable: false),
            //            Showtime_ShowtimeID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.MovieID)
            //    .ForeignKey("dbo.Showtimes", t => t.Showtime_ShowtimeID)
            //    .Index(t => t.Showtime_ShowtimeID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            //CreateTable(
            //    "dbo.Orders",
            //    c => new
            //        {
            //            OrderID = c.Int(nullable: false, identity: true),
            //            TicketID = c.Int(nullable: false),
            //            CustomerID = c.Int(nullable: false),
            //            Email = c.String(),
            //            CreditCard = c.Int(nullable: false),
            //            PopcornPoints = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Showtimes",
                c => new
                    {
                        ShowtimeID = c.Int(nullable: false, identity: true),
                        ShowtimeTime = c.DateTime(nullable: false),
                        TheaterNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowtimeID);
            
            CreateTable(
                "dbo.GenreMovies",
                c => new
                    {
                        Genre_GenreID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreID, t.Movie_MovieID })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .Index(t => t.Genre_GenreID)
                .Index(t => t.Movie_MovieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Showtime_ShowtimeID", "dbo.Showtimes");
            DropForeignKey("dbo.GenreMovies", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.GenreMovies", "Genre_GenreID", "dbo.Genres");
            DropIndex("dbo.GenreMovies", new[] { "Movie_MovieID" });
            DropIndex("dbo.GenreMovies", new[] { "Genre_GenreID" });
            DropIndex("dbo.Movies", new[] { "Showtime_ShowtimeID" });
            DropTable("dbo.GenreMovies");
            DropTable("dbo.Showtimes");
            DropTable("dbo.Orders");
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
            DropTable("dbo.Customers");
        }
    }
}
