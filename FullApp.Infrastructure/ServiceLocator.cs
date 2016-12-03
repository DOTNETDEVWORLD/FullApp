using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.Infrastructure
{
    public class ServiceLocator
    {
        public static IUnityContainer Container { private get; set; }

        public static T RecupererService<T>(string nom)
        {
            return Container.Resolve<T>(nom);
        }

        public static IEnumerable<T> RecupererServices<T>()
        {
            return Container.ResolveAll<T>();
        }
    }
}
