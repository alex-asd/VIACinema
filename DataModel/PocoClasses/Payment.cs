using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.PocoClasses
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string ClientName { get; set; }
        public long ClientPhoneNumber { get; set; }
        public string ClientEmailAddress { get; set; }
        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
