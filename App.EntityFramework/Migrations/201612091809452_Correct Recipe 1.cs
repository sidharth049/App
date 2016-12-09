namespace App.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectRecipe1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Recipes", "CreatedBy");
            RenameColumn(table: "dbo.Recipes", name: "UserId", newName: "CreatedBy");
            RenameIndex(table: "dbo.Recipes", name: "IX_UserId", newName: "IX_CreatedBy");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Recipes", name: "IX_CreatedBy", newName: "IX_UserId");
            RenameColumn(table: "dbo.Recipes", name: "CreatedBy", newName: "UserId");
            AddColumn("dbo.Recipes", "CreatedBy", c => c.Int(nullable: false));
        }
    }
}
