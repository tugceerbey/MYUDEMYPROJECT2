using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult Roomlist()
        {
            var values = _roomService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.Insert(room);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.GetByID(id);
            _roomService.Delete(values);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.Update(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _roomService.GetByID(id);
            return Ok(values);
        }
    }
}
