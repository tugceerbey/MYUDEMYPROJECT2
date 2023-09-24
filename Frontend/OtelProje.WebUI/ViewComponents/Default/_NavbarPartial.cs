using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.ViewComponents.Default
{
    public class _NavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
