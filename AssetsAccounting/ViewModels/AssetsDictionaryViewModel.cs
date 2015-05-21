using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Services;
using GalaSoft.MvvmLight.Command;

namespace AssetsAccounting.ViewModels
{
    public class AssetsDictionaryViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;

        public AssetsDictionaryViewModel(IAssetService assetService)
        {
            HeaderText = "Справочник материальных ценностей";
            _assetService = assetService;
        }
        
        #region Commands

        public ICommand AddAssetViewCommand
        {
            get { return new RelayCommand(() => ViewModel = new AddAssetViewModel()); }
        }

        #endregion

    }
}
