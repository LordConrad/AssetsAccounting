using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Events;
using AssetsAccounting.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class AddResponsibleViewModel : BaseViewModel
    {
        private readonly IUnityContainer _container;
        private readonly IResponsibleService _responsibleService;
        private string _name;
        private string _position;
        private string _authorityNumber;

        public AddResponsibleViewModel(IUnityContainer container)
        {
            _container = container;
            HeaderText = "Добавление материально ответственного лица";
            _responsibleService = container.Resolve<IResponsibleService>();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                RaisePropertyChanged();
                RaisePropertyChanged("AddResponsibleCommand");
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                if (value == _position) return;
                _position = value;
                RaisePropertyChanged();
                RaisePropertyChanged("AddResponsibleCommand");
            }
        }

        public string AuthorityNumber
        {
            get { return _authorityNumber; }
            set
            {
                if (value == _authorityNumber) return;
                _authorityNumber = value;
                RaisePropertyChanged();
                RaisePropertyChanged("AddResponsibleCommand");
            }
        }

        public ICommand AddResponsibleCommand
        {
            get { return new DelegateCommand(() =>
            {
                var responsible = new Responsible
                {
                    Name = Name,
                    Position = Position,
                    AuthorityNumber = AuthorityNumber
                };
                _responsibleService.AddResponsible(responsible);
                ResponsiblesListChangedEvent.Instance.Publish(Name);
                var shell = _container.Resolve<ShellViewModel>();
                shell.ResponsiblesDictionaryCommand.Execute(null);
            }, () => !string.IsNullOrEmpty(Position) && !string.IsNullOrEmpty(AuthorityNumber) && !string.IsNullOrEmpty(Name));}
        }

        
    }
}
