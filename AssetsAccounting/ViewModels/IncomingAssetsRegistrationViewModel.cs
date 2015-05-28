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
        public Asset SelectedAsset { get; set; }
        public IEnumerable<Provider> Providers { get; set; }
        public Provider SelectedProvider { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string DocNumber { get; set; }

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
                });
            }
        }
    }
}
