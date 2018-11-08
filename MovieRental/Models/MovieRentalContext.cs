using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieRental.Contracts;

namespace MovieRental.Models
{
    public class MovieRentalContext : DbContext, IMovieRentalContext
    {
        public MovieRentalContext() : base(@"Server=EN32254\SQLEXPRESS; database=MovieRentalDB; trusted_connection=true;")
        {
            Database.SetInitializer<MovieRentalContext>(new CreateDatabaseIfNotExists<MovieRentalContext>());
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(c => c.Customers)
                .WithMany(m => m.Movies)
                .Map(ca =>
                {
                    ca.MapLeftKey("MovieId");
                    ca.MapRightKey("CustomerId");
                    ca.ToTable("MovieCustomers");
                });
            modelBuilder.Entity<MembershipType>()
                .HasMany(c => c.Customers)
                .WithRequired(m => m.MembershipType);

            modelBuilder.Entity<Movie>()
                .HasMany(g => g.Genres)
                .WithMany(m => m.Movies)
                .Map(ca =>
                {
                    ca.MapLeftKey("MovieId");
                    ca.MapRightKey("GenreId");
                    ca.ToTable("MovieGenres");
                });
        }
    }
}