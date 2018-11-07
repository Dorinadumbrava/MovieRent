using MovieRental.Models;

namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieRental.Models.MovieRentalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieRental.Models.MovieRentalContext context)
        {
           
        }
    }
}
