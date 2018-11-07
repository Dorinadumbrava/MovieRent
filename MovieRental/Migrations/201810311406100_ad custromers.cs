namespace MovieRental.Migrations
{
    using MovieRental.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adcustromers : DbMigration
    {
        public override void Up()
        {
            using (var context = new MovieRentalContext())
            {
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Customers (FullName, IsSubscribedToNewsletter, BirthDate, MembershipType_MembershipTypeId )"
                    + " VALUES ('Arina Sharap', 1, 02/02/2000, 3)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Customers (FullName, IsSubscribedToNewsletter, BirthDate, MembershipType_MembershipTypeId )"
                    + " VALUES ('Marian Tipov', 1, 09/07/1998, 3)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Customers (FullName, IsSubscribedToNewsletter, BirthDate, MembershipType_MembershipTypeId )"
                    + " VALUES ('Cristian Siretean', 0, 03/11/2001, 4)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Customers (FullName, IsSubscribedToNewsletter, BirthDate, MembershipType_MembershipTypeId )"
                    + " VALUES ('Mihaela Pridea', 1, 12/09/1997, 5)"
                    );
               
            }
        }
        
        public override void Down()
        {
        }
    }
}
