using FullApp.FrontOffice.Ioc;
using FullApp.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FullApp.FrontOffice
{
    public class MvcApplication : System.Web.HttpApplication
    {

        private IUnityContainer container;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ConfigureIocContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private void ConfigureIocContainer()
        {
            container = new UnityContainer();

            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            var assemblies = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath ??
                                                AppDomain.CurrentDomain.BaseDirectory, "FullApp.*.dll");

            var allClasses = AllClasses.FromAssemblies(assemblies.Select(x => Assembly.LoadFile(x)));

            foreach (var c in allClasses.Where(t => t.GetInterfaces().Any(i => i.GetCustomAttributes(typeof(AutoRegisterAttribute), true).Any())))
            {
                foreach (var t in c.GetInterfaces().Where(i => i.GetCustomAttributes(typeof(AutoRegisterAttribute), true).Any()))
                {
                    container.RegisterType(t, c);
                }
            }
        }
    }
}
