namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcustomerdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerPickups",
                c => new
                    {
                        PrimaryId = c.Int(nullable: false, identity: true),
                        Id = c.String(maxLength: 128),
                        Address = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        VacationDates = c.String(nullable: false),
                        PickUpDay = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PrimaryId)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerPickups", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.CustomerPickups", new[] { "Id" });
            DropTable("dbo.CustomerPickups");
        }
    }
}
