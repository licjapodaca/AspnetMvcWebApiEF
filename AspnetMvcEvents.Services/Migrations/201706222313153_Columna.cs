namespace AspnetMvcEvents.Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Columna : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FechaNacimiento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "FechaNacimiento", c => c.DateTime(nullable: false));
        }
    }
}
