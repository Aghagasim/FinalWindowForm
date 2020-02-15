namespace FinalWindowForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerRename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Pay", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Customers", "PenaltyPay", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.Customers", "PenaltyPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PenaltyPrice", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.Customers", "PenaltyPay");
            DropColumn("dbo.Customers", "Pay");
        }
    }
}
