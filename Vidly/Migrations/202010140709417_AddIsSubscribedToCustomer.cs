namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Name", c => c.String());
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "FirstName");
            DropColumn("dbo.Customers", "SecondName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "SecondName", c => c.String());
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
            DropColumn("dbo.Customers", "Name");
        }
    }
}
