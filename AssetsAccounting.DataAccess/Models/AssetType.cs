using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    [Table("AssetTypes")]
    public class AssetType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("TypeId")]
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
