namespace FinalWindowForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Book_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Book_Id");
            AddForeignKey("dbo.Orders", "Book_Id", "dbo.Books", "Id");
            DropColumn("dbo.Customers", "Pay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Pay", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Orders", "Book_Id", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "Book_Id" });
            DropColumn("dbo.Orders", "Book_Id");
        }
    }
}
