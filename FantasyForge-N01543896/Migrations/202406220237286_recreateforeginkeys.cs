namespace FantasyForge_N01543896.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recreateforeginkeys : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.UserMediaItems", "UserID");
            CreateIndex("dbo.UserMediaItems", "MediaItemID");
            AddForeignKey("dbo.UserMediaItems", "UserID", "dbo.Users", "UserID", cascadeDelete: false);
            AddForeignKey("dbo.UserMediaItems", "MediaItemID", "dbo.MediaItems", "MediaItemID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMediaItems", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserMediaItems", "MediaItemID", "dbo.MediaItems");
            DropIndex("dbo.UserMediaItems", new[] { "UserID" });
            DropIndex("dbo.UserMediaItems", new[] { "MediaItemID" });
        }
    }
}
