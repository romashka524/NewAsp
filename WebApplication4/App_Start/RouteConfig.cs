using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "My", action = "List"}
            );

            routes.MapRoute(
              name: "one",
              url: "product/{article}",
              defaults: new { controller = "My", action = "id", name = "AB-123" },
                 constraints: new
                 {
                     name = "[A-Z]{2}-[0-9]{3}"
                 }
              );
            routes.MapRoute(
                name: "two",
                url: "product/{article}/print",
                defaults: new { controller = "My", action = "print", name = "AB-123" },
                   constraints: new
                   {
                       name = "[A-Z]{2}-[0-9]{3}"
                   }
                );
            routes.MapRoute(
              name: "three",
              url: "products/{category}/{page}",
              defaults: new { controller = "My", action = "category", category = "electronics", page = "1" },
                 constraints: new
                 {
                     category = "[a-z]+",
                     page = @"\d+"
                 }
              );
            routes.MapRoute(
              name: "four",
              url: "products/date/{date}/{page}",
              defaults: new { controller = "My", action = "date", date = "2003-02-03", page = "1" },
                 constraints: new
                 {
                     date = new prodRouteConstraint(),
                     page = @"\d+"
                 }
              );
           
        }
    }
}
