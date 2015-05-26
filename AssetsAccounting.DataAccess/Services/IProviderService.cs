using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public interface IProviderService
    {
        IEnumerable<Provider> GetProviders();
        Provider GetProviderById(int id);
        void AddProvider(Provider provider);
        void EditProvider(Provider provider);
    }
}
