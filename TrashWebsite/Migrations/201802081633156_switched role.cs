namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class switchedrole : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerPickups", "PickUpDay", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerPickups", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerPickups", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerPickups", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerPickups", "ZipCode", c => c.String(nullable: false));
            DropColumn("dbo.CustomerPickups", "PickUpDates");
            DropColumn("dbo.CustomerPickups", "Role");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerPickups", "Role", c => c.String());
            AddColumn("dbo.CustomerPickups", "PickUpDates", c => c.String());
            AlterColumn("dbo.CustomerPickups", "ZipCode", c => c.String());
            AlterColumn("dbo.CustomerPickups", "Address", c => c.String());
            AlterColumn("dbo.CustomerPickups", "LastName", c => c.String());
            AlterColumn("dbo.CustomerPickups", "FirstName", c => c.String());
            AlterColumn("dbo.CustomerPickups", "PickUpDay", c => c.String());
        }
    }
}
