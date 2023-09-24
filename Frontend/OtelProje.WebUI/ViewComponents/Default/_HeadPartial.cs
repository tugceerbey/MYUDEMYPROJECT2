using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
