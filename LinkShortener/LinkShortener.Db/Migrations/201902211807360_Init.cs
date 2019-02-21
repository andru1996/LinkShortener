namespace LinkShortener.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LinkClicks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PublishedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        Link_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Links", t => t.Link_Id, cascadeDelete: true)
                .Index(t => t.Link_Id);
            
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StringId = c.String(nullable: false),
                        Url = c.String(),
                        CreatorId = c.Guid(nullable: false),
                        Status = c.Int(nullable: false),
                        PublishedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LinkClicks", "Link_Id", "dbo.Links");
            DropIndex("dbo.LinkClicks", new[] { "Link_Id" });
            DropTable("dbo.Links");
            DropTable("dbo.LinkClicks");
        }
    }
}
