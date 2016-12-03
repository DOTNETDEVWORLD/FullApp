using FullApp.Infrastructure;
using FullApp.WebApi.Models;
using Microsoft.Practices.Unity;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace FullApp.WebApi
{
    public static class WebApiConfig
    {

        private static IUnityContainer unityContainer;

        public static void Register(HttpConfiguration config)
        {
            unityContainer = new UnityContainer();         

            ConfigureIocContainer();
            // Configuration et services API Web           
            config.DependencyResolver = new UnityResolver(unityContainer);


            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }


        private static void ConfigureIocContainer()
        {           
            var assemblies = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath ??
                                                AppDomain.CurrentDomain.BaseDirectory, "FullApp.*.dll");

            var allClasses = AllClasses.FromAssemblies(assemblies.Select(x => Assembly.LoadFrom(x)));

            foreach (var c in allClasses.Where(t => t.GetInterfaces().Any(i => i.GetCustomAttributes(typeof(AutoRegisterAttribute), true).Any())))
            {
                foreach (var t in c.GetInterfaces().Where(i => i.GetCustomAttributes(typeof(AutoRegisterAttribute), true).Any()))
                {
                    unityContainer.RegisterType(t, c);
                }
            }                 
        }
    }
}
