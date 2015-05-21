using System;
using System.Collections.Generic;
using System.Linq;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public class AssetService : IAssetService
    {
        public IEnumerable<Asset> GetAssets()
        {
            using (var context = new AssetsAccountingContext())
            {
                return context.Assets.ToList();
            }
        }

        public bool AddAsset(Asset newAsset)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    context.Assets.Add(newAsset);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
