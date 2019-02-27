using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ComicBookGallary
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //called once when the websites starts
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //to acess right click on RoutConfig and go on the GoTODefination menu
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
