namespace BitBookWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAdditionInformationOfUserTableIntoId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AdditionInformationOfUsers", name: "AdditionInformationOfUserId", newName: "Id");
            RenameIndex(table: "dbo.AdditionInformationOfUsers", name: "IX_AdditionInformationOfUserId", newName: "IX_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AdditionInformationOfUsers", name: "IX_Id", newName: "IX_AdditionInformationOfUserId");
            RenameColumn(table: "dbo.AdditionInformationOfUsers", name: "Id", newName: "AdditionInformationOfUserId");
        }
    }
}
