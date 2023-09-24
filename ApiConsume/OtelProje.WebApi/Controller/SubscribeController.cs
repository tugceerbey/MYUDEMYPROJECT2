using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult subscribeList()
        {
            var values = _subscribeService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Addsubscribe(Subscribe subscribe)
        {
            _subscribeService.Insert(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Deletesubscribe(int id)
        {
            var values = _subscribeService.GetByID(id);
            _subscribeService.Delete(values);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult Updatesubscribe(Subscribe subscribe)
        {
            _subscribeService.Update(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Getsubscribe(int id)
        {
            var values = _subscribeService.GetByID(id);
            return Ok(values);
        }
    }
}
