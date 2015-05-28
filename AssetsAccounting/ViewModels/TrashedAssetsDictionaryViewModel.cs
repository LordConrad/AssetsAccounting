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
    public class TrashedAssetsDictionaryViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;

        public TrashedAssetsDictionaryViewModel(IUnityContainer container)
        {
            _assetService = container.Resolve<IAssetService>();
            UpdateTrashedAssets(string.Empty);
            TrashedAssetsListChangedEvent.Instance.Subscribe(UpdateTrashedAssets);
        }

        public IEnumerable<TrashedAsset> TrashedAssets { get; set; }

        private void UpdateTrashedAssets(string arg)
        {
            TrashedAssets = _assetService.GetTrashedAssets();
        }
    }
}
