namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulationOfGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id, Name) values (1, 'Comedy')");
            Sql("Insert into Genres (Id, Name) values (2, 'Fantastics')");
            Sql("Insert into Genres (Id, Name) values (3, 'Thriller')");
            Sql("Insert into Genres (Id, Name) values (4, 'Adventure')");
            Sql("Insert into Genres (Id, Name) values (5, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
