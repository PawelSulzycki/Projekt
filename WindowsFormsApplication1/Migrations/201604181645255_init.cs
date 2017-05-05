namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        emailAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImageCheck",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Site = c.String(),
                        Keyword = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tasks", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.WeatherCheck",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        City = c.String(),
                        Temperature = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tasks", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeatherCheck", "Id", "dbo.Tasks");
            DropForeignKey("dbo.ImageCheck", "Id", "dbo.Tasks");
            DropIndex("dbo.WeatherCheck", new[] { "Id" });
            DropIndex("dbo.ImageCheck", new[] { "Id" });
            DropTable("dbo.WeatherCheck");
            DropTable("dbo.ImageCheck");
            DropTable("dbo.Tasks");
        }
    }
}
