using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.Controllers
{
    [AllowAnonymous]
    public class AdminLayoutController : Controller
    {
        public IActionResult AdminLayout()
        {
            return View();
        }
        public IActionResult HeadPartial()
        {
            return View();
        }
        public IActionResult PreloaderPartial()
        {
            return View();
        }
        public IActionResult NawHeaderPartial()
        {
            return View();
        }
        public IActionResult HeaderPartial()
        {
            return View();
        }
        public IActionResult SidebarPartial()
        {
            return View();
        }
        public IActionResult FooterPartial()
        {
            return View();
        }  
        public IActionResult ScriptPartial()
        {
            return View();
        }
    }
}
