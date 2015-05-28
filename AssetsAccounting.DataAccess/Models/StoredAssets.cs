using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    [Table("StoredAssets")]
    public class StoredAssets
    {
        [Key]
        public int Id { get; set; }

        public int StoredAssetId { get; set; }
        public int StoredProviderId { get; set; }
        public string DocNumber { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("StoredAssetId")]
        public virtual Asset Asset { get; set; }
        [ForeignKey("StoredProviderId")]
        public virtual Provider Provider { get; set; }
    }
}
