namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletewrongconnection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "MembershipType_MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Movies", new[] { "MembershipType_MembershipTypeId" });
            DropColumn("dbo.Movies", "MembershipType_MembershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MembershipType_MembershipTypeId", c => c.Int());
            CreateIndex("dbo.Movies", "MembershipType_MembershipTypeId");
            AddForeignKey("dbo.Movies", "MembershipType_MembershipTypeId", "dbo.MembershipTypes", "MembershipTypeId");
        }
    }
}
