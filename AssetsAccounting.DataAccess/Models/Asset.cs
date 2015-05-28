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
        
        [ForeignKey("AssetId")]
        public virtual ICollection<ResponsiblesAssets> ResponsiblesAssets { get; set; }

        [ForeignKey("StoredAssetId")]
        public virtual ICollection<StoredAssets> StoredAssets { get; set; } 
    }
}
