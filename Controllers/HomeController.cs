using System.Web.Mvc;

namespace WorkshopMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewData["Titulo"] = "Home - Index";
            ViewBag.Titulo = "Home - Index";

            return View();
        }

        public ActionResult Contato()
        {
            //ViewData["Titulo"] = "Home - Contato";
            ViewBag.Titulo = "Home - Contato";

            return View();
        }
    }
}