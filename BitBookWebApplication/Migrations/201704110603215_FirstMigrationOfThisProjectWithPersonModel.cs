namespace BitBookWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrationOfThisProjectWithPersonModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        MobileNo = c.String(),
                        Password = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false, storeType: "date"),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
