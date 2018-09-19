﻿using Br.Financas.Infra.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Br.Financas.Mvc {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IoC.Init();
            DependencyResolver.SetResolver(new IoCDependencyResolver());
        }
    }
}