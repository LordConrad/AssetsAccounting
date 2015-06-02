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
    public class AddAssetViewModel : BaseViewModel
    {
        private readonly IUnityContainer _container;
        private readonly IAssetService _assetService;
        private string _name;
        private AssetType _selectedType;

        public AddAssetViewModel(IUnityContainer container)
        {
            _container = container;
            HeaderText = "Регистрация материальных ценностей";
            _assetService = container.Resolve<IAssetService>();
            UpdateTypes(string.Empty);
            AssetTypesListChangedEvent.Instance.Subscribe(UpdateTypes);
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("SaveAssetCommand");
                }
            }
        }

        public IEnumerable<AssetType> Types { get; set; }

        public void UpdateTypes(string arg)
        {
            Types = _assetService.GetAssetTypes();
            RaisePropertyChanged("Types");
        }

        public AssetType SelectedType
        {
            get { return _selectedType; }
            set
            {
                if (Equals(value, _selectedType)) return;
                _selectedType = value;
                RaisePropertyChanged();
                RaisePropertyChanged("SaveAssetCommand");
            }
        }

        public ICommand SaveAssetCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var newAsset = new Asset
                    {
                        Name = Name,
                        TypeId = SelectedType.Id
                    };
                    _assetService.AddAsset(newAsset);
                    AssetsListChangedEvent.Instance.Publish(Name);
                    var shell = _container.Resolve<ShellViewModel>();
                    shell.AssetsDictionaryCommand.Execute(null);
                }, () => !string.IsNullOrEmpty(Name) && SelectedType != null);
            }
        }
    }
}
