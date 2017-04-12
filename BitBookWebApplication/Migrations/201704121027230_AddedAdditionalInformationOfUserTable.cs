namespace BitBookWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdditionalInformationOfUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionInformationOfUsers",
                c => new
                    {
                        AdditionInformationOfUserId = c.Int(nullable: false),
                        PhotoInByte = c.Binary(),
                        CoverPhotoInByte = c.Binary(),
                        AboutMe = c.String(),
                        Religion = c.String(),
                    })
                .PrimaryKey(t => t.AdditionInformationOfUserId)
                .ForeignKey("dbo.Users", t => t.AdditionInformationOfUserId)
                .Index(t => t.AdditionInformationOfUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdditionInformationOfUsers", "AdditionInformationOfUserId", "dbo.Users");
            DropIndex("dbo.AdditionInformationOfUsers", new[] { "AdditionInformationOfUserId" });
            DropTable("dbo.AdditionInformationOfUsers");
        }
    }
}
