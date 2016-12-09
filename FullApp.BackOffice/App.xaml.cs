using FullApp.BackOffice.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FullApp.BackOffice
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainViewModel = new MainViewModel()
            {
                CurrentView = new ProductsViewModel()
            };

            MainWindow = new MainWindow();
            MainWindow.DataContext = mainViewModel;

            MainWindow.Show();
        }
    }
}
