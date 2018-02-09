namespace TrashWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.EmployeeModels", "UserId");
            AddForeignKey("dbo.EmployeeModels", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.EmployeeModels", new[] { "UserId" });
            DropColumn("dbo.EmployeeModels", "UserId");
        }
    }
}
