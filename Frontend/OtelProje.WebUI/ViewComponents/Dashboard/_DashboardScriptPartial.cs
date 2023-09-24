using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.ViewComponents.Dashboard
{
    public class _DashboardScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
