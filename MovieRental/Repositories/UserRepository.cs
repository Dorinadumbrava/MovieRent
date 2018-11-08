using MovieRental.Contracts;
using MovieRental.Models;
using MovieRental.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieRental.Repositories
{
    public class UserRepository : IUserRepository

    {
        private DbSet<Customer> _users;

        public UserRepository()
        {
        }

        public UserRepository(IMovieRentalContext rentalContext)
        {
            _users = rentalContext.Customers;
        }

        public object GetUser()
        {
            //List<Customer> customers = new List<Customer>();
            return _users;
        }
        public object GetUserbyId( int userId)
        {
            return _users.FirstOrDefault(i=> i.CustomerId == userId);
        }
    }
}