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
    public class TrashAssetViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;
        private StoredAsset _selectedAsset;
        private int _quantity;
        private string _docNumber;
        
        public TrashAssetViewModel(IUnityContainer container)
        {
            _assetService = container.Resolve<IAssetService>();
            UpdateAssets(string.Empty);
            TrashedAssetsListChangedEvent.Instance.Subscribe(UpdateAssets);
        }

        public IEnumerable<StoredAsset> Assets { get; set; }

        public StoredAsset SelectedAsset
        {
            get { return _selectedAsset; }
            set
            {
                if (_selectedAsset != value)
                {
                    _selectedAsset = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("Quantity");
                    RaisePropertyChanged("QuantityMax");
                    RaisePropertyChanged("OveralQuantity");
                    RaisePropertyChanged("TrashAssetCommand");
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
                    RaisePropertyChanged("OveralQuantity");
                    RaisePropertyChanged("QuantityMax");
                    RaisePropertyChanged("TrashAssetCommand");
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
                    RaisePropertyChanged("TrashAssetCommand");
                }
            }
        }

        public int QuantityMax
        {
            get { return _selectedAsset != null ? _selectedAsset.Quantity : 0; }
        }

        public int OveralQuantity
        {
            get { return _selectedAsset != null ? _selectedAsset.Quantity - Quantity : 0; }
        }

        private void UpdateAssets(string arg)
        {
            Assets = _assetService.GetStoredAssets();
        }

        public ICommand TrashAssetCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var trashAsset = new TrashedAsset
                    {
                        TrashedAssetId = SelectedAsset.Asset.Id,
                        Date = SelectedAsset.Date,
                        DocNumber = DocNumber,
                        Quantity = Quantity,
                        TrashedDate = DateTime.Now
                    };
                    _assetService.TrashAsset(trashAsset);
                    _assetService.SetQuantityStoredAsset(SelectedAsset.Id, SelectedAsset.Quantity - Quantity);
                }, () => SelectedAsset != null && Quantity > 0 && !string.IsNullOrEmpty(DocNumber));
            }
        }
    }
}
