﻿using System.Web.Mvc;
using System.Web.Routing;

namespace YoseTheGame
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" });
            routes.MapRoute("Ping", "ping", new { controller = "Ping", action = "Index" });
        }
    }
}