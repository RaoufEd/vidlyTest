using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Define custom route
            //but its an old methode and messy check below to find a better way !!!!
            //which is attribute routing

            //new way
            routes.MapMvcAttributeRoutes();


            /*
            //**********************old way********************
             routes.MapRoute(
                "MoviesByReleaseDate",
                "Movie/Released/{year}/{month}",
                new{controller = "Movie", action ="ByReleaseDate"},
                //adding special parameter d means digits !

                new{year=@"\d{4}" , month =@"\d{2}"}
            );

           */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
