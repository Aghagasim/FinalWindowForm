namespace FinalWindowForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropForeignKey("dbo.Orders", "RentPrice_Id", "dbo.Books");
            DropForeignKey("dbo.Orders", "Book_Id", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropIndex("dbo.Orders", new[] { "RentPrice_Id" });
            DropIndex("dbo.Orders", new[] { "Book_Id" });
            DropColumn("dbo.Orders", "BookId");
            DropColumn("dbo.Orders", "RentPrice_Id");
            DropColumn("dbo.Orders", "Book_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Book_Id", c => c.Int());
            AddColumn("dbo.Orders", "RentPrice_Id", c => c.Int());
            AddColumn("dbo.Orders", "BookId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "Book_Id");
            CreateIndex("dbo.Orders", "RentPrice_Id");
            CreateIndex("dbo.Orders", "BookId");
            AddForeignKey("dbo.Orders", "Book_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.Orders", "RentPrice_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.Orders", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
