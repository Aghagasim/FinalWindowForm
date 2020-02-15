namespace FinalWindowForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelrename : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Books", name: "Category_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Books", name: "IX_Category_Id", newName: "IX_Genre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Books", name: "IX_Genre_Id", newName: "IX_Category_Id");
            RenameColumn(table: "dbo.Books", name: "Genre_Id", newName: "Category_Id");
        }
    }
}
