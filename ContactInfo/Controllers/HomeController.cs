using System.Web.Mvc;

namespace ContactInfo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Contact Info Appliction allows users to save Contact and Address info";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ScottVaughan.com";

            return View();
        }
    }
}