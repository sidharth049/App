namespace App.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserDetails", "User_UserId", "dbo.Users");
            DropIndex("dbo.UserDetails", new[] { "User_UserId" });
            RenameColumn(table: "dbo.UserDetails", name: "User_UserId", newName: "UserId");
            AlterColumn("dbo.UserDetails", "DisplayName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.UserDetails", "Gender", c => c.String(nullable: false, maxLength: 1));
            AlterColumn("dbo.UserDetails", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.UserDetails", "UserId");
            AddForeignKey("dbo.UserDetails", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDetails", "UserId", "dbo.Users");
            DropIndex("dbo.UserDetails", new[] { "UserId" });
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 200));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 200));
            AlterColumn("dbo.UserDetails", "UserId", c => c.Int());
            AlterColumn("dbo.UserDetails", "Gender", c => c.String(maxLength: 1));
            AlterColumn("dbo.UserDetails", "DisplayName", c => c.String(maxLength: 100));
            RenameColumn(table: "dbo.UserDetails", name: "UserId", newName: "User_UserId");
            CreateIndex("dbo.UserDetails", "User_UserId");
            AddForeignKey("dbo.UserDetails", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
