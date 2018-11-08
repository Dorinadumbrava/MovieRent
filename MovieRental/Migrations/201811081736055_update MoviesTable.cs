namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Movies", "Added", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "Added");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
