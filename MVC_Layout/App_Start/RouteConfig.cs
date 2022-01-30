using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Layout
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "StudentByAdmissionDate",
            //    url: "Admin/admission/{year}/{month}",
            //    defaults: new { controller = "Admin", action = "StudentByAddmissionsDate" }
            //    cpmstraomt" mew }uea@"\d{ 4}
            //",month=@
            //    constraints: new { year = @"2017/2018", month =@\d2 }
            //    ) ;
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
