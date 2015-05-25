using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        private UserControl _currentView;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string HeaderText { get; set; }

        public UserControl CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                if (!_currentView.Equals(value))
                {
                    _currentView = value;
                    RaisePropertyChanged("CurrentView");
                }
            }
        }
        
    }
}
