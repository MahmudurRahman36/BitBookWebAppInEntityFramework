namespace BitBookWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderIdInUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "Gender_Id" });
            RenameColumn(table: "dbo.Users", name: "Gender_Id", newName: "GenderId");
            AlterColumn("dbo.Users", "GenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "GenderId");
            AddForeignKey("dbo.Users", "GenderId", "dbo.Genders", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "GenderId", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "GenderId" });
            AlterColumn("dbo.Users", "GenderId", c => c.Int());
            RenameColumn(table: "dbo.Users", name: "GenderId", newName: "Gender_Id");
            CreateIndex("dbo.Users", "Gender_Id");
            AddForeignKey("dbo.Users", "Gender_Id", "dbo.Genders", "Id");
        }
    }
}
