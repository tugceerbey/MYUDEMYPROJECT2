using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.ViewComponents.Dashboard
{
    public class _DashboardHeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
