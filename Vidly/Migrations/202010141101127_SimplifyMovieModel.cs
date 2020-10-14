namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SimplifyMovieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte());
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
        }
    }
}
