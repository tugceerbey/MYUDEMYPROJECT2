using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
