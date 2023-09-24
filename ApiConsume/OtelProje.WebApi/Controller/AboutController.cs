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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.Insert(about);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.GetByID(id);
            _aboutService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.Update(about);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.GetByID(id);
            return Ok(values);
        }
    }
}
