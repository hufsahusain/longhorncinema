namespace LonghornCinemaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BhedaSetup3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Order_OrderID", "dbo.Orders");
            DropIndex("dbo.Tickets", new[] { "Order_OrderID" });
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        TicketPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order_OrderID = c.Int(),
                        Product_TicketID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .ForeignKey("dbo.Tickets", t => t.Product_TicketID)
                .Index(t => t.Order_OrderID)
                .Index(t => t.Product_TicketID);
            
            DropColumn("dbo.Tickets", "Order_OrderID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Order_OrderID", c => c.Int());
            DropForeignKey("dbo.OrderDetails", "Product_TicketID", "dbo.Tickets");
            DropForeignKey("dbo.OrderDetails", "Order_OrderID", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "Product_TicketID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderID" });
            DropTable("dbo.OrderDetails");
            CreateIndex("dbo.Tickets", "Order_OrderID");
            AddForeignKey("dbo.Tickets", "Order_OrderID", "dbo.Orders", "OrderID");
        }
    }
}
