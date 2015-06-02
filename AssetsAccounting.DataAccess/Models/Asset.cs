using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    [Table("Assets")]
    public class Asset
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TypeId { get; set; }
        
        [ForeignKey("ResponsibleAssetId")]
        public virtual ICollection<ResponsiblesAssets> ResponsiblesAssets { get; set; }
        [ForeignKey("StoredAssetId")]
        public virtual ICollection<StoredAsset> StoredAssets { get; set; } 
        [ForeignKey("TrashedAssetId")]
        public virtual ICollection<TrashedAsset> TrashedAssets { get; set; } 
        [ForeignKey("TypeId")]
        public AssetType AssetType { get; set; }
    }
}
