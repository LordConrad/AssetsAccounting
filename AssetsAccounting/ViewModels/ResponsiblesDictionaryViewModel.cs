using System.Collections.Generic;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Events;
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
            ResponsibleAssetsListChangedEvent.Instance.Subscribe(UpdateResponsiblesList);
        }

        public IEnumerable<Responsible> Responsibles { get; set; }

        private void UpdateResponsiblesList(string args)
        {
            Responsibles = _responsibleService.GetResponsibles();
        }

        

    }
}
