using FullApp.BackOffice.ViewModels;
using FullApp.BackOffice.ViewModels.Navigation;
using FullApp.DomainModel;
using FullApp.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace FullApp.BackOffice
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer container;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ConfigureIocContainer();

            var navigation = container.Resolve<NavigationViewModel>();

            navigation.NavigateTo(container.Resolve<ProductListViewModel>());

            MainWindow = new MainWindow()
            {
                DataContext = navigation
            };

            MainWindow.Show();
        }

        private void ConfigureIocContainer()
        {

            container = new UnityContainer();
            container.RegisterType<NavigationViewModel>(new ContainerControlledLifetimeManager());

            //string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            //var assemblies = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath ??
            //                                    AppDomain.CurrentDomain.BaseDirectory, "FullApp.*.dll");

            //var allClasses = AllClasses.FromAssemblies(assemblies.Select(x => Assembly.LoadFile(x)));

            //foreach (var c in allClasses.Where(t => t.GetInterfaces().Any(i => i.GetCustomAttributes(typeof(AutoRegisterAttribute), true).Any())))
            //{
            //    foreach (var t in c.GetInterfaces().Where(i => i.GetCustomAttributes(typeof(AutoRegisterAttribute), true).Any()))
            //    {
            //        container.RegisterType(t, c);
            //    }
            //}
        }

    
    }
}
