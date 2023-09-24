using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.Insert(service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.GetByID(id);
            _serviceService.Delete(values);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.Update(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.GetByID(id);
            return Ok(values);
        }
    }
}
