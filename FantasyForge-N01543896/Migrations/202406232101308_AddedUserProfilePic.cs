namespace FantasyForge_N01543896.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserProfilePic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserHasPic", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "PicExtension", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PicExtension");
            DropColumn("dbo.Users", "UserHasPic");
        }
    }
}
