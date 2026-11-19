using System.Web.Mvc;
using System.Web.Routing;

namespace Practical11
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // The portal opens directly on the service request list
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ServiceRequest", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
