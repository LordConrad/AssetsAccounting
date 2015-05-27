using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.ViewModels;
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

            #region register view models

            container.RegisterType<MainViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<AssetsDictionaryViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<ProvidersDictionaryViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<ResponsiblesDictionaryViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<AddProviderViewModel>(new ContainerControlledLifetimeManager());

            #endregion


            container.RegisterType<IAssetService, AssetService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IProviderService, ProviderService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IResponsibleService, ResponsibleService>(new ContainerControlledLifetimeManager());
            

            MainWindow mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

    }
}
