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

        public AddAssetViewModel(IUnityContainer container)
        {
            _container = container;
            HeaderText = "Регистрация материальных ценностей";
            _assetService = container.Resolve<IAssetService>();
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

        public ICommand SaveAssetCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var newAsset = new Asset
                    {
                        Name = Name
                    };
                    _assetService.AddAsset(newAsset);
                    AssetsListChangedEvent.Instance.Publish(Name);
                    var shell = _container.Resolve<ShellViewModel>();
                    shell.AssetsDictionaryCommand.Execute(null);
                }, () => !string.IsNullOrEmpty(Name));
            }
        }
    }
}
