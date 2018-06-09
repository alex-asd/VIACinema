using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataModel.PocoClasses
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MovieImage { get; set; }
        public DateTime StartTime { get; set; }
        public int DurationInMinutes { get; set; }
        public double TicketPrice { get; set; }
        public virtual List<Premiere> Premieres { get; set; }
    }
}
