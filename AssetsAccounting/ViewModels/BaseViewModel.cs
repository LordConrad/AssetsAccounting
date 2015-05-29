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
        private User _currentUser;
        public event PropertyChangedEventHandler PropertyChanged;

        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (Equals(value, _currentUser)) return;
                _currentUser = value;
                RaisePropertyChanged();
                RaisePropertyChanged("IsEditEnable");
            }
        }

        public bool IsEditEnable
        {
            get { return _currentUser != null && _currentUser.IsEditEnable; }
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
