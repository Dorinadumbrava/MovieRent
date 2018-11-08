namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkeynavprop : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "MembershipType_MembershipTypeId", newName: "MembershipTypeId");
            RenameIndex(table: "dbo.Customers", name: "IX_MembershipType_MembershipTypeId", newName: "IX_MembershipTypeId");
            AddColumn("dbo.Customers", "MovieId", c => c.Int(nullable: false));
            AddColumn("dbo.MembershipTypes", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.Genres", "MoviesId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "MoviesId");
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "CustomerId");
            DropColumn("dbo.MembershipTypes", "CustomerId");
            DropColumn("dbo.Customers", "MovieId");
            RenameIndex(table: "dbo.Customers", name: "IX_MembershipTypeId", newName: "IX_MembershipType_MembershipTypeId");
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeId", newName: "MembershipType_MembershipTypeId");
        }
    }
}
