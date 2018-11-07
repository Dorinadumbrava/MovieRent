namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Int(nullable: false));
            AddColumn("dbo.MembershipTypes", "MonthsOfMembership", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "Price");
            DropColumn("dbo.MembershipTypes", "Discount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Discount", c => c.Int(nullable: false));
            AddColumn("dbo.MembershipTypes", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.MembershipTypes", "DiscountRate");
            DropColumn("dbo.MembershipTypes", "MonthsOfMembership");
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
