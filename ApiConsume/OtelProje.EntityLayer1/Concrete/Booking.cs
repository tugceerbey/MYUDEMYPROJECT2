using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.EntityLayer1.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }
        public String Name { get; set; }
        public String Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }
        public String AdultCount { get; set; }
        public String ChildCount { get; set; }
        public String RoomCount { get; set; }
        public String SpecialRequest { get; set; }
        public String Description { get; set; }
        public String Status { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
    }
}
