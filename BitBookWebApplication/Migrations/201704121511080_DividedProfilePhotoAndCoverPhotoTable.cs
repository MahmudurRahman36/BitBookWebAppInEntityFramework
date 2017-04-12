namespace BitBookWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DividedProfilePhotoAndCoverPhotoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoverPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeNo = c.Int(nullable: false),
                        PhotoInByte = c.Binary(),
                        AdditionInformationOfUserId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdditionInformationOfUsers", t => t.AdditionInformationOfUserId, cascadeDelete: false)
                .Index(t => t.AdditionInformationOfUserId);
            
            CreateTable(
                "dbo.ProfilePhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeNo = c.Int(nullable: false),
                        PhotoInByte = c.Binary(),
                        AdditionInformationOfUserId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdditionInformationOfUsers", t => t.AdditionInformationOfUserId, cascadeDelete: false)
                .Index(t => t.AdditionInformationOfUserId);
            
            AddColumn("dbo.AdditionInformationOfUsers", "ProfilePhotoId", c => c.Int(nullable: false));
            AddColumn("dbo.AdditionInformationOfUsers", "CoverPhotoId", c => c.Int(nullable: false));
            DropColumn("dbo.AdditionInformationOfUsers", "PhotoInByte");
            DropColumn("dbo.AdditionInformationOfUsers", "CoverPhotoInByte");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdditionInformationOfUsers", "CoverPhotoInByte", c => c.Binary());
            AddColumn("dbo.AdditionInformationOfUsers", "PhotoInByte", c => c.Binary());
            DropForeignKey("dbo.ProfilePhotoes", "AdditionInformationOfUserId", "dbo.AdditionInformationOfUsers");
            DropForeignKey("dbo.CoverPhotoes", "AdditionInformationOfUserId", "dbo.AdditionInformationOfUsers");
            DropIndex("dbo.ProfilePhotoes", new[] { "AdditionInformationOfUserId" });
            DropIndex("dbo.CoverPhotoes", new[] { "AdditionInformationOfUserId" });
            DropColumn("dbo.AdditionInformationOfUsers", "CoverPhotoId");
            DropColumn("dbo.AdditionInformationOfUsers", "ProfilePhotoId");
            DropTable("dbo.ProfilePhotoes");
            DropTable("dbo.CoverPhotoes");
        }
    }
}
