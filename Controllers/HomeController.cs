using System.Web.Mvc;

namespace WorkshopMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello World";
        }

        public string Contato()
        {
            return "Entre em contato!";
        }
    }
}