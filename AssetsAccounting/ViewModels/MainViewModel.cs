using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private readonly IUnityContainer _container;

        
        public MainViewModel(IUnityContainer container)
        {
            HeaderText = "MAIN";
            
            _container = container;
            
        }



        #region Commands

        public ICommand ProvidersDictionaryCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<ProvidersDictionaryView>()); }
        }

        public ICommand ResponsiblesDictionaryCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<ResponsiblesDictionaryView>()); }
        }

        public ICommand AssetsDictionaryCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<AssetsDictionaryView>()); }
        }

        #endregion

        
        
    }
}
