namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        MembershipType_MembershipTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipType_MembershipTypeId, cascadeDelete: true)
                .Index(t => t.MembershipType_MembershipTypeId);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        MembershipTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SignUpFee = c.Int(nullable: false),
                        MonthsOfMembership = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.MembershipTypeId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MembershipType_MembershipTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipType_MembershipTypeId)
                .Index(t => t.MembershipType_MembershipTypeId);
            
            CreateTable(
                "dbo.MovieCustomers",
                c => new
                    {
                        MovieId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieId, t.CustomerId })
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MembershipType_MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.MovieCustomers", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.MovieCustomers", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Customers", "MembershipType_MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.MovieCustomers", new[] { "CustomerId" });
            DropIndex("dbo.MovieCustomers", new[] { "MovieId" });
            DropIndex("dbo.Movies", new[] { "MembershipType_MembershipTypeId" });
            DropIndex("dbo.Customers", new[] { "MembershipType_MembershipTypeId" });
            DropTable("dbo.MovieCustomers");
            DropTable("dbo.Movies");
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Customers");
        }
    }
}
