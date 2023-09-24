using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Insert(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
          var values=  _staffService.GetByID(id);
            _staffService.Delete(values);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.Update(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values=_staffService.GetByID(id);
            return Ok(values);
        }
        [HttpGet("{Last4Staff}")]
        public IActionResult Last4Staff()
        {
            var values = _staffService.TLast4Staff();
            return Ok(values);
        }
    }
}
