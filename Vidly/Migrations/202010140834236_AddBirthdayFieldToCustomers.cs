namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddBirthdayFieldToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
