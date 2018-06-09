using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataModel.PocoClasses
{
    public class CinemaHall
    {
        public int CinemaHallId { get; set; }
        public string CinemaHallName { get; set; }
        public int NumberOfSeats { get; set; }
        public virtual List<Premiere> Premieres { get; set; }
    }
}
