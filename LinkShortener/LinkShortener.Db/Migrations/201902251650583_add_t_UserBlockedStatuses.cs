namespace LinkShortener.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_t_UserBlockedStatuses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBlockedStatuses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        PublishedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserBlockedStatuses");
        }
    }
}
