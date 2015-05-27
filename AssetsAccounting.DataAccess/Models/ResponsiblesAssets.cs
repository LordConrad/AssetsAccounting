using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    [Table("ResponsiblesAssets")]
    public class ResponsiblesAssets
    {
        [Key]
        public int Id { get; set; }

        public int ResponsibleId { get; set; }
        public int AssetId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string DocNumber { get; set; }

        [ForeignKey("ResponsibleId")]
        public virtual Responsible Responsible { get; set; }
        [ForeignKey("AssetId")]
        public virtual Asset Asset { get; set; }
    }
}
