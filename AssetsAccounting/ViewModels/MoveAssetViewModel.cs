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
    public class MoveAssetViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;
        private readonly IResponsibleService _responsibleService;
        private StoredAsset _selectedAsset;
        private Responsible _selectedResponsible;
        private string _docNumber;
        private int _quantity;

        public MoveAssetViewModel(IUnityContainer container)
        {
            HeaderText = "Перемещение материалов";
            _assetService = container.Resolve<IAssetService>();
            _responsibleService = container.Resolve<IResponsibleService>();
            UpdateDatasets(string.Empty);
            StoredAssetsListChangedEvent.Instance.Subscribe(UpdateDatasets);
            ResponsiblesListChangedEvent.Instance.Subscribe(UpdateDatasets);
        }

        public IEnumerable<StoredAsset> StoredAssets { get; set; }
        public IEnumerable<Responsible> Responsibles { get; set; }

        public StoredAsset SelectedAsset
        {
            get { return _selectedAsset; }
            set
            {
                if (_selectedAsset != value)
                {
                    _selectedAsset = value;
                    RaiseProperties();
                }
            }
        }

        public Responsible SelectedResponsible
        {
            get { return _selectedResponsible; }
            set
            {
                if (_selectedResponsible != value)
                {
                    _selectedResponsible = value;
                    RaiseProperties();
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
                    RaiseProperties();
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
                    RaiseProperties();
                }
            }
        }
        public int MaxQuantity { get { return SelectedAsset != null ? SelectedAsset.Quantity : 0; } }

        private void RaiseProperties()
        {
            RaisePropertyChanged("DocNumber");
            RaisePropertyChanged("Quantity");
            RaisePropertyChanged("SelectedAsset");
            RaisePropertyChanged("SelectedResponsible");
            RaisePropertyChanged("MoveAssetCommand");
            RaisePropertyChanged("MaxQuantity");
        }

        private void UpdateDatasets(string arg)
        {
            StoredAssets = _assetService.GetStoredAssets();
            Responsibles = _responsibleService.GetResponsibles();
        }

        public ICommand MoveAssetCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var movedAsset = new ResponsiblesAssets
                    {
                        ResponsibleAssetId = SelectedAsset.Id,
                        Date = DateTime.Now,
                        DocNumber = DocNumber,
                        Quantity = Quantity,
                        ResponsibleId = SelectedResponsible.Id
                    };
                    _assetService.AddResponsibleAsset(movedAsset);
                    _assetService.SetQuantityStoredAsset(SelectedAsset.Id, SelectedAsset.Quantity - Quantity);
                    ResponsibleAssetsListChangedEvent.Instance.Publish(string.Empty);
                }, () => SelectedAsset != null && SelectedResponsible != null && !string.IsNullOrEmpty(DocNumber) && Quantity > 0);
            }
        }

    }
}
