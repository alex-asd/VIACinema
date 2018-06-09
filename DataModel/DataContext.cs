using DataModel.PocoClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class DataContext : DbContext
    {
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Premiere> Premieres { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<CarouselMovie> CarouselMovies { get; set; }
    }
}
