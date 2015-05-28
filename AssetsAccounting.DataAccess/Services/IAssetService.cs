using System.Collections.Generic;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public interface IAssetService
    {
        IEnumerable<Asset> GetAssets();
        Asset GetAsset(int id);
        void AddAsset(Asset newAsset);
        void RemoveAsset(int id);
        void AddStoredAsset(StoredAsset asset);
        IEnumerable<StoredAsset> GetStoredAssets();
        IEnumerable<TrashedAsset> GetTrashedAssets();
        void TrashAsset(TrashedAsset trashAsset);
        void AddResponsibleAsset(ResponsiblesAssets movedAsset);
        void SetQuantityStoredAsset(int id, int quantity);
    }
}
