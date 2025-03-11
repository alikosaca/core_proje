using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var value = serviceManager.GetList();
            ViewBag.v1 = "Hizmet Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Listesi";
            return View(value);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Hizmet Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Listesi";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetBytID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Hizmet Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Listesi";
            var value = serviceManager.TGetBytID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
