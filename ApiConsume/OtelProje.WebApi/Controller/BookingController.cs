using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.Insert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            _bookingService.Delete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.Update(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            return Ok(values);
        }

        [HttpGet("Last6Booking")]
        public IActionResult Last6Booking()
        {
            var values = _bookingService.TLast6Bookings();
            return Ok(values);
        }

        [HttpGet("BookingAproved")]
        public IActionResult BookingAproved(int id)
        {
            _bookingService.BookingStatusChangeApproved3(id);
            return Ok();
        }

        [HttpGet("BookingCancel")]
        public IActionResult BookingCancel(int id)
        {
            _bookingService.BookingStatusChangeCancel(id);
            return Ok();
        }
        [HttpGet("BookingWait")]
        public IActionResult BookingWait(int id)
        {
            _bookingService.BookingStatusChangeWait(id);
            return Ok();
        }
    }
}
