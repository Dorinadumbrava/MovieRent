namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using MovieRental.Models;

    public partial class adddata : DbMigration
    {
        public override void Up()
        {
            using (var context = new MovieRentalContext())
            {
               
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Pay as You Go', 0, 0, 0)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Monthly', 30, 1, 10)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Quarterly', 90, 3, 15)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.MembershipTypes (Name, SignUpFee, MonthsOfMembership, DiscountRate)"
                    + " VALUES ('Annual', 300, 12, 20)"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Movies (Name)"
                    + " VALUES ('Shrek')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Movies (Name)"
                    + " VALUES ('Mister Nobody')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Movies (Name)"
                    + " VALUES ('Fountain')"
                    );
                context.Database.ExecuteSqlCommand(
                    "INSERT INTO dbo.Movies (Name)"
                    + " VALUES ('The Labyrinth')"
                    );
                
               
            }
        }
        
        public override void Down()
        {
        }
    }
}
