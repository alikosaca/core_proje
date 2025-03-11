using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
