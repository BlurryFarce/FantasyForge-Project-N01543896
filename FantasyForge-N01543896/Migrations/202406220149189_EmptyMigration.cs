namespace FantasyForge_N01543896.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserMediaItems", "MediaItemID");
            RenameColumn(table: "dbo.UserMediaItems", name: "Title", newName: "MediaItemID");
            RenameIndex(table: "dbo.UserMediaItems", name: "IX_Title", newName: "IX_MediaItemID");
            DropColumn("dbo.UserMediaItems", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserMediaItems", "UserName", c => c.String());
            RenameIndex(table: "dbo.UserMediaItems", name: "IX_MediaItemID", newName: "IX_Title");
            RenameColumn(table: "dbo.UserMediaItems", name: "MediaItemID", newName: "Title");
            AddColumn("dbo.UserMediaItems", "MediaItemID", c => c.Int(nullable: false));
        }
    }
}
