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
        private readonly IProviderService _providerService;
        private readonly IAssetService _assetService;
        private Asset _selectedAsset;
        private Provider _selectedProvider;
        private int _quantity;
        private DateTime _date;
        private string _docNumber;

        public IncomingAssetsRegistrationViewModel(IUnityContainer container)
        {
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
                    RaiseEvents();
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
                    RaiseEvents();
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
                    RaiseEvents();
                }
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    RaiseEvents();
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
                    RaiseEvents();
                }
            }
        }

        private void RaiseEvents()
        {
            RaisePropertyChanged("SelectedAsset");
            RaisePropertyChanged("SelectedProvider");
            RaisePropertyChanged("Date");
            RaisePropertyChanged("DocNumber");
            RaisePropertyChanged("Quantity");
            RaisePropertyChanged("AddIncomingAsset");
        }

        private void UpdateDataSets(string arg)
        {
            Assets = _assetService.GetAssets();
            Providers = _providerService.GetProviders();
        }

        public ICommand AddIncomingAsset
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var newIncomingAsset = new StoredAsset
                    {
                        Asset = SelectedAsset,
                        Date = Date,
                        DocNumber = DocNumber,
                        Quantity = Quantity,
                        Provider = SelectedProvider
                    };
                    _assetService.AddStoredAsset(newIncomingAsset);
                    StoredAssetsListChangedEvent.Instance.Publish(SelectedAsset.Name);
                }, () => !string.IsNullOrEmpty(DocNumber) && Quantity > 0 && SelectedProvider != null && SelectedAsset != null);
            }
        }
    }
}
