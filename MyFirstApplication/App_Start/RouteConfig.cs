using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    "NewAcion",
            //    "movies/Released/{year}/{month}",
            //    new { controller = "movies", action = "Released", year = UrlParameter.Optional, month = UrlParameter.Optional },
            //    // d repres. digit and no. in curly braces repres.repetition of digit. 
            //    //new { year=@"\d{4}",month=@"\d{2}"}
            //    //here only 2 years are allowed
            //    new { year = @"2020|2021", month = @"\d{2}" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
