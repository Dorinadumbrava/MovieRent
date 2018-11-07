using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class MembershipType
    {
        [Key]
        public int MembershipTypeId { get; set; }
        public string Name { get; set; }
        public int SignUpFee { get; set; }
        public byte MonthsOfMembership { get; set; }
        public byte DiscountRate { get; set; }
        public IList<Customer> Customers { get; set; }
    }
}