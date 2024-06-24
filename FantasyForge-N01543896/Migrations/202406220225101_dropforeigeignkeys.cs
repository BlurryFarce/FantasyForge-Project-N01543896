namespace FantasyForge_N01543896.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropforeigeignkeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserMediaItems", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserMediaItems", "MediaItemID", "dbo.MediaItems");
            DropIndex("dbo.UserMediaItems", new[] { "UserID" });
            DropIndex("dbo.UserMediaItems", new[] { "MediaItemID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.UserMediaItems", "UserID");
            CreateIndex("dbo.UserMediaItems", "MediaItemID");
            AddForeignKey("dbo.UserMediaItems", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.UserMediaItems", "MediaItemID", "dbo.MediaItems", "MediaItemID", cascadeDelete: true);
        }
    }
}
