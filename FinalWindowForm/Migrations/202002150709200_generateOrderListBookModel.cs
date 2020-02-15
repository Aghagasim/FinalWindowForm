namespace FinalWindowForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class generateOrderListBookModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Book_Id", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "Book_Id" });
            CreateTable(
                "dbo.OrderListBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        TotalPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.OrderId);
            
            DropColumn("dbo.Orders", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Book_Id", c => c.Int());
            DropForeignKey("dbo.OrderListBooks", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderListBooks", "BookId", "dbo.Books");
            DropIndex("dbo.OrderListBooks", new[] { "OrderId" });
            DropIndex("dbo.OrderListBooks", new[] { "BookId" });
            DropTable("dbo.OrderListBooks");
            CreateIndex("dbo.Orders", "Book_Id");
            AddForeignKey("dbo.Orders", "Book_Id", "dbo.Books", "Id");
        }
    }
}
