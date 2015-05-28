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
        void AddStoredAsset(StoredAssets asset);
    }
}
