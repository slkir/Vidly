namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Romantic')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Fantastic')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Thriller')");
        }

        public override void Down()
        {
        }
    }
}
