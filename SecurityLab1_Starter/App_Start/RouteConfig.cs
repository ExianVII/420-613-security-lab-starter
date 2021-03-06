﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { action = "Contact|About|GenError"}
            );

            routes.MapRoute(
                name:"Inventory",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Inventory", action = "Index", id = UrlParameter.Optional}
                );

            routes.MapRoute(
              name: "Account",
              url: "Account/Login",
              defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
          );
            routes.MapRoute (
                name: "AccountLogout",
                url: "Account/Logout",
                defaults: new { controller = "Account", action = "Logout", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Error",
                url: "Error/ServerError",
                defaults: new { controller = "Error", action = "ServerError" }
                );

            routes.MapRoute(
                name: "404-PageNotFound",
                url: "{*url}",
                 defaults: new { controller = "Error", action = "NotFound" }
                );
        }
    }
}
