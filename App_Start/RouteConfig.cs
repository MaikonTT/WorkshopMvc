using System.Web.Mvc;
using System.Web.Routing;

namespace WorkshopMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home.Index",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Home.Contato",
                url: "contato",
                defaults: new { controller = "Home", action = "Contato" }
            );
        }
    }
}