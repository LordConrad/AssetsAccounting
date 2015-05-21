using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace AssetsAccounting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IAssetService, AssetService>(new ContainerControlledLifetimeManager());

            MainWindow mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

    }
}
