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

            MainViewModel.Instance.NavigateTo(new ProductListViewModel());


            MainWindow = new MainWindow();
            MainWindow.DataContext = MainViewModel.Instance;

            MainWindow.Show();
        }
    }
}
