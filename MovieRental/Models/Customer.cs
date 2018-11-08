using System;
using System.Collections.Generic;

namespace MovieRental.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public int MovieId { get; set; }
        public virtual List<Movie> Movies { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public DateTime? BirthDate { get; set; }
        public int MembershipTypeId { get; set; }
        public virtual MembershipType MembershipType { get; set; }
        
    }
}