using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;
        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            _messageCategoryService = messageCategoryService;
        }

        [HttpGet]
        public IActionResult MessageCategoryList()
        {
            var values = _messageCategoryService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.Insert(messageCategory);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var values = _messageCategoryService.GetByID(id);
            _messageCategoryService.Delete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.Update(messageCategory);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMessageCategory(int id)
        {
            var values = _messageCategoryService.GetByID(id);
            return Ok(values);
        }
    }
}
