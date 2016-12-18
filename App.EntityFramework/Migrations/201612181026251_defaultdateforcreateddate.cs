namespace App.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class defaultdateforcreateddate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RecipeComments", "CreatedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Recipes", "CreatedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Users", "CreatedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.UserDetails", "CreatedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDetails", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Recipes", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RecipeComments", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
