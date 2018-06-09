namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarouselMovies",
                c => new
                    {
                        CarouselMovieId = c.Int(nullable: false, identity: true),
                        MovieURL = c.String(),
                        MovieDescription = c.String(),
                    })
                .PrimaryKey(t => t.CarouselMovieId);
            
            CreateTable(
                "dbo.CinemaHalls",
                c => new
                    {
                        CinemaHallId = c.Int(nullable: false, identity: true),
                        CinemaHallName = c.String(),
                        NumberOfSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinemaHallId);
            
            CreateTable(
                "dbo.Premieres",
                c => new
                    {
                        PremiereId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        CinemaHallId = c.Int(nullable: false),
                        PremiereDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PremiereId)
                .ForeignKey("dbo.CinemaHalls", t => t.CinemaHallId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.CinemaHallId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        MovieDescription = c.String(),
                        MovieImage = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        DurationInMinutes = c.Int(nullable: false),
                        TicketPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatId = c.Int(nullable: false, identity: true),
                        SeatRow = c.Int(nullable: false),
                        SeatColumn = c.Int(nullable: false),
                        Booked = c.Boolean(nullable: false),
                        PremiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeatId)
                .ForeignKey("dbo.Premieres", t => t.PremiereId, cascadeDelete: true)
                .Index(t => t.PremiereId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        ClientPhoneNumber = c.Long(nullable: false),
                        ClientEmailAddress = c.String(),
                        SeatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Seats", t => t.SeatId, cascadeDelete: true)
                .Index(t => t.SeatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "PremiereId", "dbo.Premieres");
            DropForeignKey("dbo.Payments", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Premieres", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Premieres", "CinemaHallId", "dbo.CinemaHalls");
            DropIndex("dbo.Payments", new[] { "SeatId" });
            DropIndex("dbo.Seats", new[] { "PremiereId" });
            DropIndex("dbo.Premieres", new[] { "CinemaHallId" });
            DropIndex("dbo.Premieres", new[] { "MovieId" });
            DropTable("dbo.Payments");
            DropTable("dbo.Seats");
            DropTable("dbo.Movies");
            DropTable("dbo.Premieres");
            DropTable("dbo.CinemaHalls");
            DropTable("dbo.CarouselMovies");
        }
    }
}
