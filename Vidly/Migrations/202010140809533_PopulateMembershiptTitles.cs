namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershiptTitles : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Title = 'Pay As You Go' where id = 1");
            Sql("UPDATE MembershipTypes set Title = '1 Month' where id = 2");
            Sql("UPDATE MembershipTypes set Title = '3 Month' where id = 3");
            Sql("UPDATE MembershipTypes set Title = '12 Month' where id = 4");
        }

        public override void Down()
        {
        }
    }
}
