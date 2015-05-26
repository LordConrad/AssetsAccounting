using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public class ProviderService : IProviderService
    {
        public IEnumerable<Provider> GetProviders()
        {
            using (var context = new AssetsAccountingContext())
            {
                return context.Providers.ToList();
            }
        }

        public Provider GetProviderById(int id)
        {
            using (var context = new AssetsAccountingContext())
            {
                return context.Providers.FirstOrDefault(x => x.Id.Equals(id));
            }
        }

        public void AddProvider(Provider provider)
        {
            using (var context = new AssetsAccountingContext())
            {
                context.Entry(provider).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void EditProvider(Provider provider)
        {
            using (var context = new AssetsAccountingContext())
            {
                context.Entry(provider).State = EntityState.Modified;
            }
        }
    }
}
