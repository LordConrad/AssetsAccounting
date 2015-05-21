using System.Collections.Generic;
using AssetsAccounting.DataAccess.Models;

namespace AssetsAccounting.DataAccess.Services
{
    public interface IAssetService
    {
        IEnumerable<Asset> GetAssets();
        bool AddAsset(Asset newAsset);
    }
}
