namespace FinalWindowForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forsearching : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderListBooks", "Customer_Id", c => c.Int());
            CreateIndex("dbo.OrderListBooks", "Customer_Id");
            AddForeignKey("dbo.OrderListBooks", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderListBooks", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.OrderListBooks", new[] { "Customer_Id" });
            DropColumn("dbo.OrderListBooks", "Customer_Id");
        }
    }
}
