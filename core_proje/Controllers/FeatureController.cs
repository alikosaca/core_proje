using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
