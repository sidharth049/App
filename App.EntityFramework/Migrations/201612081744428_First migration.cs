namespace App.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserDetailId = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Country = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.UserDetailId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDetails", "User_UserId", "dbo.Users");
            DropIndex("dbo.UserDetails", new[] { "User_UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserDetails");
        }
    }
}
