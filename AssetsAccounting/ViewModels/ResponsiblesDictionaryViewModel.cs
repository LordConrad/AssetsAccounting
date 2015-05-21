using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace AssetsAccounting.ViewModels
{
    public class ResponsiblesDictionaryViewModel : BaseViewModel
    {
        public ResponsiblesDictionaryViewModel()
        {
            HeaderText = "Справочник материально ответственных лиц";
        }

        public ICommand AddResponsibleViewCommand
        {
            get { return new RelayCommand(() => ViewModel = new AddResponsibleViewModel()); }
        }
    }
}
