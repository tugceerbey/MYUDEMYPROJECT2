using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;
        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }

        [HttpGet]
        public IActionResult WorkLocationList()
        {
            var values = _workLocationService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.Insert(workLocation);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.GetByID(id);
            _workLocationService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.Update(workLocation);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkLocation(int id)
        {
            var values = _workLocationService.GetByID(id);
            return Ok(values);
        }
    }
}
