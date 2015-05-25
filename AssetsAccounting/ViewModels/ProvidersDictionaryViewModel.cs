using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class ProvidersDictionaryViewModel : BaseViewModel
    {
        private readonly IUnityContainer _container;

        public ProvidersDictionaryViewModel(IUnityContainer container)
        {
            HeaderText = "Справочник поставщиков";
            _container = container;
        }

        public string ProviderContent { get { return "provoder content..."; } }

        #region Commands

        public ICommand AddProviderCommand
        {
            get { return new DelegateCommand(() => CurrentView = _container.Resolve<AddProviderView>()); }
        }

        #endregion
    }
}
