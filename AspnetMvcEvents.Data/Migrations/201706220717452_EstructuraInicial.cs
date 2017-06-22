namespace AspnetMvcEvents.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstructuraInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        StartDateTime = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        PresenterId = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        Location = c.String(maxLength: 200),
                        IsPublic = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Presenters", t => t.PresenterId, cascadeDelete: true)
                .Index(t => t.PresenterId);
            
            CreateTable(
                "dbo.Presenters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Lastname = c.String(nullable: false, maxLength: 30),
                        ProfessionalSkills = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "PresenterId", "dbo.Presenters");
            DropIndex("dbo.Events", new[] { "PresenterId" });
            DropTable("dbo.Presenters");
            DropTable("dbo.Events");
        }
    }
}
