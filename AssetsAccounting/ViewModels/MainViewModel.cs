using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using GalaSoft.MvvmLight.Command;

namespace AssetsAccounting.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        
        

        
        public MainViewModel()
        {
            HeaderText = "MAIN";
        }

        #region Commands

        public ICommand ProvidersDictionaryCommand
        {
            get { return new RelayCommand(() => ViewModel = new ProvidersDictionaryViewModel()); }
        }

        public ICommand ResponsiblesDictionaryCommand
        {
            get { return new RelayCommand(() => ViewModel = new ResponsiblesDictionaryViewModel()); }
        }

        

        #endregion

        
        
    }
}
