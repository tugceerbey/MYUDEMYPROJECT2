using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendMessageService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.Insert(sendMessage);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values = _sendMessageService.GetByID(id);
            _sendMessageService.Delete(values);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.Update(sendMessage);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _sendMessageService.GetByID(id);
            return Ok(values);
        }
        [HttpGet("{GetSendMessageCount}")]
        public IActionResult GetSendMessageCount()
        {
            return Ok(_sendMessageService.TGetSendMessageCount());
        }
    }
}
