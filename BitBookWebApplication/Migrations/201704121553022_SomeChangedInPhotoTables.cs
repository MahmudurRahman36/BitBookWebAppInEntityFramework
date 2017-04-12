namespace BitBookWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChangedInPhotoTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CoverPhotoes", "DateTimeNow", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProfilePhotoes", "DateTimeNow", c => c.DateTime(nullable: false));
            DropColumn("dbo.CoverPhotoes", "DateTime");
            DropColumn("dbo.ProfilePhotoes", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProfilePhotoes", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.CoverPhotoes", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.ProfilePhotoes", "DateTimeNow");
            DropColumn("dbo.CoverPhotoes", "DateTimeNow");
        }
    }
}
