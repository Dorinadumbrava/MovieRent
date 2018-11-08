namespace MovieRental.Migrations
{
    using MovieRental.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populategenres : DbMigration
    {
        public override void Up()
        {
            using (var context = new MovieRentalContext())
            {
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (GenreName)"
                    + " VALUES ('Comedy')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (GenreName)"
                    + " VALUES ('Historical')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (GenreName)"
                    + " VALUES ('Thriller')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (GenreName)"
                    + " VALUES ('Drama')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Genres (GenreName)"
                    + " VALUES ('Animated')"
                    );
            }
        }        
        
        public override void Down()
        {
        }
    }
}
