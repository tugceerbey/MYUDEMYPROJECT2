using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.Insert(testimonial);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.GetByID(id);
            _testimonialService.Delete(values);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.Update(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.GetByID(id);
            return Ok(values);
        }
    }
}