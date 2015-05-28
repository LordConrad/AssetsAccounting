using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    [Table("TrashedAssets")]
    public class TrashedAsset
    {
        [Key]
        public int Id { get; set; }

        public int TrashedAssetId { get; set; }
        public string DocNumber { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public DateTime TrashedDate { get; set; }

        [ForeignKey("TrashedAssetId")]
        public virtual Asset Asset { get; set; }
    }
}
