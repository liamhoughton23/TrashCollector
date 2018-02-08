namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nomoreforeignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerPickups", "TableId", "dbo.AspNetUsers");
            DropIndex("dbo.CustomerPickups", new[] { "TableId" });
            AddColumn("dbo.CustomerPickups", "Id_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.CustomerPickups", "TableId", c => c.String());
            CreateIndex("dbo.CustomerPickups", "Id_Id");
            AddForeignKey("dbo.CustomerPickups", "Id_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerPickups", "Id_Id", "dbo.AspNetUsers");
            DropIndex("dbo.CustomerPickups", new[] { "Id_Id" });
            AlterColumn("dbo.CustomerPickups", "TableId", c => c.String(maxLength: 128));
            DropColumn("dbo.CustomerPickups", "Id_Id");
            CreateIndex("dbo.CustomerPickups", "TableId");
            AddForeignKey("dbo.CustomerPickups", "TableId", "dbo.AspNetUsers", "Id");
        }
    }
}
