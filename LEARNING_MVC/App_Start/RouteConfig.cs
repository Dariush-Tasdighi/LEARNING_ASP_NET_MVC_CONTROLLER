using System.Web.Mvc;

namespace LEARNING_MVC
{
	public class RouteConfig
	{
		public RouteConfig()
		{
		}

		public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = System.Web.Mvc.UrlParameter.Optional }
			);
		}
	}
}
