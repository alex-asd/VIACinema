using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.PocoClasses
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }
        public bool Booked { get; set; }
        public int PremiereId { get; set; }
        public virtual Premiere Premiere { get; set; }
        public virtual List<Payment> Payments { get; set; }
    }
}
