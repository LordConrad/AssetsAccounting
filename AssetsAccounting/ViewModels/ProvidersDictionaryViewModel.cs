using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssetsAccounting.DataAccess.Models;
using AssetsAccounting.DataAccess.Services;
using AssetsAccounting.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.ViewModels
{
    public class ProvidersDictionaryViewModel : BaseViewModel
    {
        private readonly IProviderService _providerService;

        public ProvidersDictionaryViewModel(IUnityContainer container)
        {
            HeaderText = "Справочник поставщиков";
            _providerService = container.Resolve<IProviderService>();
            Providers = _providerService.GetProviders();
        }

        public IEnumerable<Provider> Providers { get; set; }

        

    }
}
