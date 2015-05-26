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

        public Asset GetAsset(int id)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    return context.Assets.FirstOrDefault(x => x.Id.Equals(id));
                }
            }
            catch(Exception ex)
            { }
            return null;
        }

        public void RemoveAsset(int id)
        {
            using (var context = new AssetsAccountingContext())
            {
                var asset = new Asset {Id = id};
                context.Assets.Attach(asset);
                context.Assets.Remove(asset);
                context.SaveChanges();
            }
        }

        public void AddAsset(Asset newAsset)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    context.Assets.Add(newAsset);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
