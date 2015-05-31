using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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

        public void AddStoredAsset(StoredAsset asset)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    context.Entry(asset).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public IEnumerable<StoredAsset> GetStoredAssets()
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    return context.StoredAssets
                        .Include(x => x.Asset)
                        .Include(x => x.Provider)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        
        public IEnumerable<TrashedAsset> GetTrashedAssets()
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    return context.TrashedAssets
                        .Include(x => x.Asset)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public void TrashAsset(TrashedAsset trashAsset)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    context.TrashedAssets.Add(trashAsset);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void AddResponsibleAsset(ResponsiblesAssets movedAsset)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    context.Entry(movedAsset).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void SetQuantityStoredAsset(int id, int quantity)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    var asset = context.StoredAssets.FirstOrDefault(x => x.Id.Equals(id));
                    if (asset != null)
                    {
                        if (quantity <= 0)
                        {
                            context.StoredAssets.Remove(asset);
                        }
                        else
                        {
                            asset.Quantity = quantity;
                        }
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public IEnumerable<ResponsiblesAssets> GetResponsibleAssets(int id)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    return context.ResponsiblesAssets
                        .Include(x => x.Asset)
                        .ToList();
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        public void AddAsset(Asset newAsset)
        {
            try
            {
                using (var context = new AssetsAccountingContext())
                {
                    context.Entry(newAsset).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
