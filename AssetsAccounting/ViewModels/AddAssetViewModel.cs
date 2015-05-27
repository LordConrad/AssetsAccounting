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
        private readonly IAssetService _assetService;

        public AddAssetViewModel(IUnityContainer container)
        {
            HeaderText = "Регистрация материальных ценностей";
            _assetService = container.Resolve<IAssetService>();
        }

        public string Name { get; set; }

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
                });
            }
        }
    }
}
