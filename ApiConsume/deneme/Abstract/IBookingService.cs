using OtelProje.EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelproje.BusinessLayer1.Abstract
{
    public interface IBookingService: IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);
        void TBookingStatusChangeApproved2(int id);
        int  GetBookingCount();
        List<Booking> TLast6Bookings();
        void BookingStatusChangeApproved3(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
    }
}
