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
    public class AddProviderViewModel : BaseViewModel
    {
        private Provider _provider;
        private readonly IProviderService _providerService;

        public AddProviderViewModel(IUnityContainer container)
        {
            HeaderText = "Добавление поставщика";
            _providerService = container.Resolve<IProviderService>();
            
        }

        public Provider Provider
        {
            get { return _provider; }
            set
            {
                if (!_provider.Equals(value))
                {
                    _provider = value;
                    RaisePropertyChanged();
                }
            }
        }

        public void EditProvider(Provider provider)
        {
            _provider = provider;
        }

        public ICommand AddProviderCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var newProvider = new Provider
                    {
                        Name = Name,
                        Address = Address,
                        Phone = Phone
                    };
                    _providerService.AddProvider(newProvider);
                    ProvidersListChangedEvent.Instance.Publish(newProvider.Name);
                });
            }
        }
    

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
