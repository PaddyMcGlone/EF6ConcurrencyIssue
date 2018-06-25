using EF6Concurrency.Services;
using System.Web.Mvc;

namespace EF6Concurrency.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Service()
        {
            var importService = new ImportService();
             importService.Execute();

            ViewBag.Message = "You have executed the service.";
            
            return View();
        }
    }
}