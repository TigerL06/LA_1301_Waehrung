using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

                routes.MapRoute(
                     name: "Hello",
                     url: "{controller}/{action}/{name}/{id}"
                 );
            }
        }


        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}