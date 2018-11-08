namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedgenrestable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        MovieId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieId, t.GenreId })
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieGenres", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.MovieGenres", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieGenres", new[] { "GenreId" });
            DropIndex("dbo.MovieGenres", new[] { "MovieId" });
            DropTable("dbo.MovieGenres");
            DropTable("dbo.Genres");
        }
    }
}
