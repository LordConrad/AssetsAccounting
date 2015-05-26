using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Events;
using AssetsAccounting.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class ProvidersDictionaryViewModel : BaseViewModel
    {
        private readonly IProviderService _providerService;
        private IEnumerable<Provider> _providers;

        public ProvidersDictionaryViewModel(IUnityContainer container)
        {
            HeaderText = "Справочник поставщиков";
            _providerService = container.Resolve<IProviderService>();
            UpdateProvidersList(string.Empty);
            ProvidersListChangedEvent.Instance.Subscribe(UpdateProvidersList);
        }

        public IEnumerable<Provider> Providers
        {
            get { return _providers; }
            set
            {
                _providers = value;
                RaisePropertyChanged();
            }
        }

        private void UpdateProvidersList(string param)
        {
            Providers = _providerService.GetProviders();
        }

    }
}
