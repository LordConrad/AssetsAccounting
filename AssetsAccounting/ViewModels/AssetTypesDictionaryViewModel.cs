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
    public class AssetTypesDictionaryViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;

        public AssetTypesDictionaryViewModel(IUnityContainer container)
        {
            HeaderText = "Справочник типов материалов";
            _assetService = container.Resolve<IAssetService>();
            UpdateAssetTypes(string.Empty);
            AssetTypesListChangedEvent.Instance.Subscribe(UpdateAssetTypes);
        }

        public IEnumerable<AssetType> AssetTypes { get; set; }

        private void UpdateAssetTypes(string arg)
        {
            AssetTypes = _assetService.GetAssetTypes();
            RaisePropertyChanged();
        }
    }
}
