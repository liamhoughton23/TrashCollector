namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteddebt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CustomerPickups", "Debt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerPickups", "Debt", c => c.String());
        }
    }
}
