namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyMembershiptTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Title", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Title");
        }
    }
}
