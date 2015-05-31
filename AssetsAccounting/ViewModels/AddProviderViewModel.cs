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
        private readonly IUnityContainer _container;
        private readonly IProviderService _providerService;
        private string _name;
        private string _address;
        private string _phone;

        public AddProviderViewModel(IUnityContainer container)
        {
            _container = container;
            HeaderText = "Добавление поставщика";
            _providerService = container.Resolve<IProviderService>();
            
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
                    var shell = _container.Resolve<ShellViewModel>();
                    shell.ProvidersDictionaryCommand.Execute(null);
                }, () => !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(Phone));
            }
        }

        private void RaisePropertiesChanged()
        {
            RaisePropertyChanged("Address");
            RaisePropertyChanged("Name");
            RaisePropertyChanged("Phone");
            RaisePropertyChanged("AddProviderCommand");
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertiesChanged();
                }
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (_name != value)
                {
                    _address = value;
                    RaisePropertiesChanged();
                }
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    RaisePropertiesChanged();
                }
            }
        }
    }
}
