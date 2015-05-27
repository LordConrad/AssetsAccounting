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
        private readonly IResponsibleService _responsibleService;

        public AddResponsibleViewModel(IUnityContainer container)
        {
            HeaderText = "Добавление материально ответственного лица";
            _responsibleService = container.Resolve<IResponsibleService>();
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public string AuthorityNumber { get; set; }

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
            });}
        }

        
    }
}
