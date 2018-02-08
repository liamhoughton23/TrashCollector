namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tookawayforeignkey : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CustomerPickups", name: "TableId", newName: "UserId");
            RenameIndex(table: "dbo.CustomerPickups", name: "IX_TableId", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CustomerPickups", name: "IX_UserId", newName: "IX_TableId");
            RenameColumn(table: "dbo.CustomerPickups", name: "UserId", newName: "TableId");
        }
    }
}
