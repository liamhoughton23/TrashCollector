namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedemployee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerPickups", "PickUpDay", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerPickups", "PickUpDay", c => c.String(nullable: false));
        }
    }
}
