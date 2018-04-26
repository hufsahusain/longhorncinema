namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BhedaSetup6 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MovieGenres", newName: "GenreMovies");
            RenameColumn(table: "dbo.OrderDetails", name: "Product_TicketID", newName: "Ticket_TicketID");
            RenameIndex(table: "dbo.OrderDetails", name: "IX_Product_TicketID", newName: "IX_Ticket_TicketID");
            DropPrimaryKey("dbo.GenreMovies");
            AddColumn("dbo.Orders", "OrderNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Tickets", "Quantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Movies", "Ticket_TicketID", c => c.Int());
            AddPrimaryKey("dbo.GenreMovies", new[] { "Genre_GenreID", "Movie_MovieID" });
            CreateIndex("dbo.Movies", "Ticket_TicketID");
            AddForeignKey("dbo.Movies", "Ticket_TicketID", "dbo.Tickets", "TicketID");
            DropColumn("dbo.Tickets", "TicketPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "TicketPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Movies", "Ticket_TicketID", "dbo.Tickets");
            DropIndex("dbo.Movies", new[] { "Ticket_TicketID" });
            DropPrimaryKey("dbo.GenreMovies");
            DropColumn("dbo.Movies", "Ticket_TicketID");
            DropColumn("dbo.Tickets", "Quantity");
            DropColumn("dbo.Tickets", "Price");
            DropColumn("dbo.Orders", "OrderNumber");
            AddPrimaryKey("dbo.GenreMovies", new[] { "Movie_MovieID", "Genre_GenreID" });
            RenameIndex(table: "dbo.OrderDetails", name: "IX_Ticket_TicketID", newName: "IX_Product_TicketID");
            RenameColumn(table: "dbo.OrderDetails", name: "Ticket_TicketID", newName: "Product_TicketID");
            RenameTable(name: "dbo.GenreMovies", newName: "MovieGenres");
        }
    }
}
