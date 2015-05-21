using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Services;
using Microsoft.Practices.Prism.Commands;

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
            get { return new DelegateCommand(() => ViewModel = new AddAssetViewModel()); }
        }

        #endregion

    }
}
