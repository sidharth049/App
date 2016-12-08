namespace App.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatingprop : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDetails", "DisplayName", c => c.String(maxLength: 100));
            AlterColumn("dbo.UserDetails", "Gender", c => c.String(maxLength: 1));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 200));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.UserDetails", "Gender", c => c.String());
            AlterColumn("dbo.UserDetails", "DisplayName", c => c.String());
        }
    }
}
