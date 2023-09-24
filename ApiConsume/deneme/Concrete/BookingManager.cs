using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.DataAccessLayer1.EntityFramework;
using OtelProje.EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangeApproved(booking);
        }

        public void BookingStatusChangeApproved2(int id)
        {
            _bookingDal.BookingStatusChangeApproved2(id);
        }

        public void BookingStatusChangeApproved3(int id)
        {
            _bookingDal.BookingStatusChangeApproved3(id);
        }

        public void BookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public void BookingStatusChangeWait(int id)
        {
            _bookingDal.BookingStatusChangeWait(id);
        }

        public void Delete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public int GetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public Booking GetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void Insert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public List<Booking> Last6Bookings()
        {
            return _bookingDal.Last6Bookings();
        }

        public void Update(Booking t)
        {
            _bookingDal.Update(t);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> TLast6Bookings()
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
