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
    public class ResponsiblesDictionaryViewModel : BaseViewModel
    {
        private readonly IResponsibleService _responsibleService;

        public ResponsiblesDictionaryViewModel(IUnityContainer container)
        {
            HeaderText = "Справочник материально ответственных лиц";
            _responsibleService = container.Resolve<IResponsibleService>();
            UpdateResponsiblesList(string.Empty);
            ResponsiblesListChangedEvent.Instance.Subscribe(UpdateResponsiblesList);
        }

        public IEnumerable<Responsible> Responsibles { get; set; }

        private void UpdateResponsiblesList(string args)
        {
            Responsibles = _responsibleService.GetResponsibles();
        }

        

    }
}
