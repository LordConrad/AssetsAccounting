using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Events;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class AddAssetTypeViewModel : BaseViewModel
    {
        private readonly IUnityContainer _container;
        private readonly IAssetService _assetService;
        private string _name;

        public AddAssetTypeViewModel(IUnityContainer container)
        {
            HeaderText = "Добавление типа материалов";
            _container = container;
            _assetService = container.Resolve<IAssetService>();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                RaisePropertyChanged();
                RaisePropertyChanged("SaveAssetTypeCommand");
            }
        }

        public ICommand SaveAssetTypeCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var newAssetType = new AssetType { Name = Name};
                    _assetService.AddAssetType(newAssetType);
                    AssetTypesListChangedEvent.Instance.Publish(Name);
                    var shell = _container.Resolve<ShellViewModel>();
                    shell.AssetTypesDictionaryCommand.Execute(string.Empty);
                }, () => !string.IsNullOrEmpty(Name));
            }
        }
        
    }
}
