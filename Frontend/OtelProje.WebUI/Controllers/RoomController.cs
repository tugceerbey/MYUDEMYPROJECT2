using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.Controllers
{
    [AllowAnonymous]
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
