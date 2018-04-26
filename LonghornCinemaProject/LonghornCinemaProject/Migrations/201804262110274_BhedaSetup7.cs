namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BhedaSetup7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "Ticket_TicketID", "dbo.Tickets");
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "Ticket_TicketID" });
            AddColumn("dbo.Tickets", "TicketPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Tickets", "Showtime_ShowtimeID", c => c.Int());
            AddColumn("dbo.Tickets", "Order_OrderID", c => c.Int());
            AddColumn("dbo.Showtimes", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Tickets", "Quantity", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "Showtime_ShowtimeID");
            CreateIndex("dbo.Tickets", "Order_OrderID");
            AddForeignKey("dbo.Tickets", "Showtime_ShowtimeID", "dbo.Showtimes", "ShowtimeID");
            AddForeignKey("dbo.Tickets", "Order_OrderID", "dbo.Orders", "OrderID");
            DropColumn("dbo.Tickets", "Price");
            DropTable("dbo.OrderDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        TicketPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order_OrderID = c.Int(),
                        Ticket_TicketID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailID);
            
            AddColumn("dbo.Tickets", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Tickets", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Tickets", "Showtime_ShowtimeID", "dbo.Showtimes");
            DropIndex("dbo.Tickets", new[] { "Order_OrderID" });
            DropIndex("dbo.Tickets", new[] { "Showtime_ShowtimeID" });
            AlterColumn("dbo.Tickets", "Quantity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Showtimes", "Price");
            DropColumn("dbo.Tickets", "Order_OrderID");
            DropColumn("dbo.Tickets", "Showtime_ShowtimeID");
            DropColumn("dbo.Tickets", "TicketPrice");
            CreateIndex("dbo.OrderDetails", "Ticket_TicketID");
            CreateIndex("dbo.OrderDetails", "Order_OrderID");
            AddForeignKey("dbo.OrderDetails", "Ticket_TicketID", "dbo.Tickets", "TicketID");
            AddForeignKey("dbo.OrderDetails", "Order_OrderID", "dbo.Orders", "OrderID");
        }
    }
}
