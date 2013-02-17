using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Kambao.Windsor;
using Microsoft.AspNet.SignalR;

namespace Kambao
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected IWindsorContainer container = new WindsorContainer();

        protected void Application_Start()
        {
            container.Install(
                new DataInstaller(),
                new ControllersInstaller());

            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory(container.Kernel));
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Register the default hubs route: ~/signalr
            RouteTable.Routes.MapHubs();
        }
    }
}