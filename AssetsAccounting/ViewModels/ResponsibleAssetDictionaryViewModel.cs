using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Events;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class ResponsibleAssetDictionaryViewModel : BaseViewModel
    {
        private readonly IAssetService _assetService;
        private readonly IResponsibleService _responsibleService;
        private Responsible _selectedResponsible;

        public ResponsibleAssetDictionaryViewModel(IUnityContainer container)
        {
            HeaderText = "Материалы на мат. отв. лице";
            _assetService = container.Resolve<IAssetService>();
            _responsibleService = container.Resolve<IResponsibleService>();
            UpdateResponsiblesList(string.Empty);
            ResponsiblesListChangedEvent.Instance.Subscribe(UpdateResponsiblesList);
        }

        public IEnumerable<Responsible> Responsibles { get; set; }
        public IEnumerable<ResponsiblesAssets> ResponsibleAssets { get; set; }

        public Responsible SelectedResponsible
        {
            get { return _selectedResponsible; }
            set
            {
                if (_selectedResponsible != value)
                {
                    _selectedResponsible = value;
                    
                    if (_selectedResponsible != null)
                    {
                        ResponsibleAssets = _assetService.GetResponsibleAssets(_selectedResponsible.Id);
                    }
                    RaisePropertyChanged();
                    RaisePropertyChanged("ResponsibleAssets");
                }
            }
        }


        private void UpdateResponsiblesList(string arg)
        {
            Responsibles = _responsibleService.GetResponsibles();
        }
    }
}
