using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Documents;
using AssetsAccounting.Annotations;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsEditEnable
        {
            get { return App.CurrentUser != null && App.CurrentUser.IsEditEnable; }
        }

        public bool IsReadEnable
        {
            get { return App.CurrentUser != null; }
        }

        public string HeaderText { get; set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
