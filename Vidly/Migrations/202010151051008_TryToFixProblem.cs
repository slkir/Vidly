namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryToFixProblem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Genres", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Genres", new[] { "Movie_Id" });
            DropColumn("dbo.Genres", "Movie_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Genres", "Movie_Id");
            AddForeignKey("dbo.Genres", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}
