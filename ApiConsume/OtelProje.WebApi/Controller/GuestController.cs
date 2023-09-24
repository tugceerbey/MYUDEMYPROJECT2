using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _guestService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.Insert(guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.GetByID(id);
            _guestService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.Update(guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestService.GetByID(id);
            return Ok(values);
        }
    }
}
