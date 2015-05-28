using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Events;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class IncomingAssetDictionaryViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;

        public IncomingAssetDictionaryViewModel(IUnityContainer container)
        {
            _assetService = container.Resolve<IAssetService>();
            UpdateStoredAssets(string.Empty);
            StoredAssetsListChangedEvent.Instance.Subscribe(UpdateStoredAssets);
        }


        public IEnumerable<StoredAsset> StoredAssets { get; set; }

        private void UpdateStoredAssets(string arg)
        {
            StoredAssets = _assetService.GetStoredAssets();
        }
    }
}
