using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Events;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class IncomingAssetsRegistrationViewModel : BaseViewModel
    {
        private readonly IUnityContainer _container;
        private readonly IProviderService _providerService;
        private readonly IAssetService _assetService;
        private Asset _selectedAsset;
        private Provider _selectedProvider;
        private int _quantity;
        private DateTime _date;
        private string _docNumber;
        private int _price;
        private string _invoice;

        public IncomingAssetsRegistrationViewModel(IUnityContainer container)
        {
            _container = container;
            _providerService = container.Resolve<IProviderService>();
            _assetService = container.Resolve<IAssetService>();
            HeaderText = "Регистрация поступления материалов";
            Date = DateTime.Now;
            UpdateDataSets(string.Empty);
            AssetsListChangedEvent.Instance.Subscribe(UpdateDataSets);
            ProvidersListChangedEvent.Instance.Subscribe(UpdateDataSets);
        }

        public IEnumerable<Asset> Assets { get; set; }

        public Asset SelectedAsset
        {
            get { return _selectedAsset; }
            set
            {
                if (_selectedAsset != value)
                {
                    _selectedAsset = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("AddIncomingAssetCommand");
                }
            }
        }

        public IEnumerable<Provider> Providers { get; set; }

        public Provider SelectedProvider
        {
            get { return _selectedProvider; }
            set
            {
                if (_selectedProvider != value)
                {
                    _selectedProvider = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("AddIncomingAssetCommand");
                }
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("AddIncomingAssetCommand");
                }
            }
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value == _price) return;
                _price = value;
                RaisePropertyChanged();
                RaisePropertyChanged("AddIncomingAssetCommand");
            }
        }

        public string Invoice
        {
            get { return _invoice; }
            set
            {
                if (value == _invoice) return;
                _invoice = value;
                RaisePropertyChanged();
                RaisePropertyChanged("AddIncomingAssetCommand");
            }
        }

        public DateTime Date
        {
            get { return _date.Date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("AddIncomingAssetCommand");
                }
            }
        }

        public string DocNumber
        {
            get { return _docNumber; }
            set
            {
                if (_docNumber != value)
                {
                    _docNumber = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("AddIncomingAssetCommand");
                }
            }
        }

        
        private void UpdateDataSets(string arg)
        {
            Assets = _assetService.GetAssets();
            Providers = _providerService.GetProviders();
        }

        public ICommand AddIncomingAssetCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var newIncomingAsset = new StoredAsset
                    {
                        StoredAssetId = SelectedAsset.Id,
                        Date = Date,
                        DocNumber = DocNumber,
                        Quantity = Quantity,
                        StoredProviderId = SelectedProvider.Id,
                        Price = Price,
                        Invoice = Invoice
                    };
                    _assetService.AddStoredAsset(newIncomingAsset);
                    StoredAssetsListChangedEvent.Instance.Publish(SelectedAsset.Name);
                    var shell = _container.Resolve<ShellViewModel>();
                    shell.IncomingAssetDictionaryCommand.Execute(null);
                }, () => !string.IsNullOrEmpty(DocNumber) && Quantity > 0 && SelectedProvider != null && SelectedAsset != null && Price > 0 && !string.IsNullOrEmpty(Invoice));
            }
        }
    }
}
