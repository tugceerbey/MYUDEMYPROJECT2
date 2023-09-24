using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DtoLayer1.Dtos.RoomDto;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult>Index()
        {
            var values = _roomService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();  
            }
            var values = _mapper.Map<Room>(roomAddDto);
           _roomService.Insert(values);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(updateRoomDto);
            _roomService.Update(values);
            return Ok("Başarıyla Güncellendi");



        }
    }
}
