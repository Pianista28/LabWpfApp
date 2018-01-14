namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.pon13_228108_A",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.pon13_228108_C",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 200),
                        IdArticle = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.pon13_228108_A", t => t.IdArticle, cascadeDelete: true)
                .Index(t => t.IdArticle);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.pon13_228108_C", "IdArticle", "dbo.pon13_228108_A");
            DropIndex("dbo.pon13_228108_C", new[] { "IdArticle" });
            DropTable("dbo.pon13_228108_C");
            DropTable("dbo.pon13_228108_A");
        }
    }
}
