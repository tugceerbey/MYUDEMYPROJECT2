using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Otelproje.BusinessLayer1.Abstract;

namespace OtelProje.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        //[HttpGet]
        //public IActionResult UserListWithWorkLocation()
        //{
        //    var values = _appUserService.TUserListWithWorkLocation();
        //    return Ok(values);
        //}
        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUserService.GetList();
            return Ok(values);
        }
    }
}
