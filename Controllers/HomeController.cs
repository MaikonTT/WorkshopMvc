using System.Web.Mvc;

namespace WorkshopMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }
    }
}