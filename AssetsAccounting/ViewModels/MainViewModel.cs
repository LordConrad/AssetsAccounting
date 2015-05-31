using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IUserService _userService;
        private string _username;
        private string _password;
        private readonly IUnityContainer _container;

        public MainViewModel(IUnityContainer container)
        {
            _container = container;
            HeaderText = "Автоматизация учета материальных средств на ОАО «Ивацевичдрев»";
            _userService = container.Resolve<IUserService>();
        }

        public string Username
        {
            get { return _username; }
            set
            {
                if (value == _username) return;
                _username = value;
                RaisePropertyChanged();
                RaisePropertyChanged("LoginCommand");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value == _password) return;
                _password = value;
                RaisePropertyChanged();
                RaisePropertyChanged("LoginCommand");
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    App.CurrentUser = _userService.Authenticate(Username, Password);
                    if (App.CurrentUser == null)
                    {
                        MessageBox.Show("Неверно имя пользователя или пароль", "Ошибка", MessageBoxButton.OK,MessageBoxImage.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Текущий пользователь: " + App.CurrentUser.Username, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    var shell = _container.Resolve<ShellViewModel>();
                    shell.UpdateEnablingOptions();
                }, () => !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password));
            }
        }
        
    }
}
