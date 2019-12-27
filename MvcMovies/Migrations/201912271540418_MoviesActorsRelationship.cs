namespace MvcMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesActorsRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieActors",
                c => new
                    {
                        Movie_ID = c.Int(nullable: false),
                        Actor_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_ID, t.Actor_ID })
                .ForeignKey("dbo.Movies", t => t.Movie_ID, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_ID, cascadeDelete: true)
                .Index(t => t.Movie_ID)
                .Index(t => t.Actor_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieActors", "Actor_ID", "dbo.Actors");
            DropForeignKey("dbo.MovieActors", "Movie_ID", "dbo.Movies");
            DropIndex("dbo.MovieActors", new[] { "Actor_ID" });
            DropIndex("dbo.MovieActors", new[] { "Movie_ID" });
            DropTable("dbo.MovieActors");
        }
    }
}
