namespace MovieRental.Migrations
{
    using MovieRental.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatedMovieGenresandMovieCustomers : DbMigration
    {
        public override void Up()
        {
            using (var context = new MovieRentalContext())
            {
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieGenres (MovieId, GenreId)"
                    + " VALUES (1, 1)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieGenres (MovieId, GenreId)"
                    + " VALUES (1, 5)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieGenres (MovieId, GenreId)"
                    + " VALUES (2, 4)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieGenres (MovieId, GenreId)"
                    + " VALUES (3, 4)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieGenres (MovieId, GenreId)"
                    + " VALUES (4, 4)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieGenres (MovieId, GenreId)"
                    + " VALUES (4, 3)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (1, 1)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (1, 2)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (2, 1)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (2, 3)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (3, 1)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (3, 3)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (4, 2)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MovieCustomers (MovieId, CustomerId)"
                    + " VALUES (4, 3)"
                    );
            }
            }
        
        public override void Down()
        {
        }
    }
}
