using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.ViewComponents.Default
{
    public class _SpinnerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
