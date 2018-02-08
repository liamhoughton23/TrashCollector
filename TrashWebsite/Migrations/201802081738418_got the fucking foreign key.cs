namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gotthefuckingforeignkey : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CustomerPickups", new[] { "Id_Id" });
            DropColumn("dbo.CustomerPickups", "TableId");
            RenameColumn(table: "dbo.CustomerPickups", name: "Id_Id", newName: "TableId");
            AlterColumn("dbo.CustomerPickups", "TableId", c => c.String(maxLength: 128));
            CreateIndex("dbo.CustomerPickups", "TableId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CustomerPickups", new[] { "TableId" });
            AlterColumn("dbo.CustomerPickups", "TableId", c => c.String());
            RenameColumn(table: "dbo.CustomerPickups", name: "TableId", newName: "Id_Id");
            AddColumn("dbo.CustomerPickups", "TableId", c => c.String());
            CreateIndex("dbo.CustomerPickups", "Id_Id");
        }
    }
}
