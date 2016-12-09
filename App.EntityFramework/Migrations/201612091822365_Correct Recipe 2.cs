namespace App.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectRecipe2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RecipeComments",
                c => new
                    {
                        RecipeCommentId = c.Int(nullable: false, identity: true),
                        Comment = c.String(nullable: false),
                        RecipeId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.RecipeCommentId)
                .ForeignKey("dbo.Recipes", t => t.RecipeId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreatedBy, cascadeDelete: false)
                .Index(t => t.RecipeId)
                .Index(t => t.CreatedBy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeComments", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.RecipeComments", "RecipeId", "dbo.Recipes");
            DropIndex("dbo.RecipeComments", new[] { "CreatedBy" });
            DropIndex("dbo.RecipeComments", new[] { "RecipeId" });
            DropTable("dbo.RecipeComments");
        }
    }
}
