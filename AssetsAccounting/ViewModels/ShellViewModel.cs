using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using AssetsAccounting.Annotations;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private IUnityContainer _container;
        private UserControl _currentView;
        private List<UserControl> _viewsList;

        public void UpdateEnablingOptions()
        {
            RaisePropertyChanged("IsEditEnable");
        }

        public ShellViewModel(IUnityContainer container)
        {
            _container = container;
            _viewsList = new List<UserControl>
            {
                _container.Resolve<MainView>()
            };
            _currentView = _viewsList.FirstOrDefault();
        }

        public UserControl CurrentView
        {
            get { return _currentView; }
            set
            {
                if (!_viewsList.Contains(value))
                {
                    _viewsList.Add(value);
                }
                _currentView = _viewsList.FirstOrDefault(x => x.Equals(value));
                RaisePropertyChanged();
            }
        }

        #region Commands

        public ICommand AddAssetViewCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<AddAssetView>()); }
        }

        public ICommand AddResponsibleViewCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<AddResponsibleView>()); }
        }

        public ICommand AddProviderCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<AddProviderView>()); }
        }

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

        public ICommand IncomingAssetRegistrationCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<IncomingAssetsRegistrationView>()); }
        }

        public ICommand IncomingAssetDictionaryCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<IncomingAssetDictionaryView>()); }
        }

        public ICommand TrashAssetViewCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<TrashAssetView>()); }
        }

        public ICommand TrashAssetsDictionaryViewCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<TrashedAssetsDictionaryView>()); }
        }

        public ICommand MoveAssetViewCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<MoveAssetView>()); }
        }


        public ICommand ResponsibleAssetDictionaryViewCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<ResponsibleAssetDictionaryView>()); }
        }
        #endregion

    }
}
