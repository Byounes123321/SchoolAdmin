using System.Web.Mvc;
using System.Web.Routing;

namespace SchoolAdmin
{
    public class Startup
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Configure your routes here
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Register global filters here
            filters.Add(new HandleErrorAttribute());
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
