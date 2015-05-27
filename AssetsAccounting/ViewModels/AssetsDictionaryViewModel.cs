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
    public class AssetsDictionaryViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;

        public AssetsDictionaryViewModel(IUnityContainer container)
        {
            HeaderText = "Справочник материальных ценностей";
            _assetService = container.Resolve<IAssetService>();
            UpdateAssetsList(string.Empty);
            AssetsListChangedEvent.Instance.Subscribe(UpdateAssetsList);
        }

        public IEnumerable<Asset> Assets { get; set; }

        private void UpdateAssetsList(string param)
        {
            Assets = _assetService.GetAssets();
        }
        
    }
}
