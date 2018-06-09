using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.PocoClasses
{
    public class Premiere
    {
        public int PremiereId { get; set; }
        public int MovieId { get; set; }
        public int CinemaHallId { get; set; }
        public DateTime PremiereDate { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual CinemaHall CinemaHall { get; set; }
        public virtual List<Seat> Seats { get; set; }
    }
}
