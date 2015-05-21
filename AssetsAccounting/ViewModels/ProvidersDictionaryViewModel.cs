using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace AssetsAccounting.ViewModels
{
    public class ProvidersDictionaryViewModel : BaseViewModel
    {
        #region Commands

        public ICommand ProvidersDictionaryCommand
        {
            get { return new RelayCommand(() => ViewModel = new ProvidersDictionaryViewModel()); }
        }

        #endregion
    }
}
