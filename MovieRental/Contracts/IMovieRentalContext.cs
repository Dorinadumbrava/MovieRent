using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Contracts
{
    public interface IMovieRentalContext
    {
        DbSet<Movie> Movies { get;}
        DbSet<Customer> Customers { get;}
        DbSet<MembershipType> MembershipTypes { get;}
    }
}
