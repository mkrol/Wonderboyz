﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Wonderboyz.Web.Plumbing;
using Castle.MicroKernel.Registration;

namespace Wonderboyz.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            
            BootstrapContainer();
        }
 
        public void Application_End()
        {
            container.Dispose();
        }
 
 
        private static void BootstrapContainer()
        {
           container = new WindsorContainer()
                .Install(FromAssembly.This());
            
            var controllerFactory = new Wonderboyz.Web.Plumbing.WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
 
        static IWindsorContainer container;
        public IWindsorContainer Container
        {
            get { return container; }
        }
    }
}