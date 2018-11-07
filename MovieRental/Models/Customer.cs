using System.Collections.Generic;

namespace MovieRental.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public List<Movie> Movies { get; set; }
        
        public MembershipType MembershipType { get; set; }
        
    }
}