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
        public int Count { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("ResponsibleId")]
        public Responsible Responsible { get; set; }
        [ForeignKey("AssetId")]
        public Asset Asset { get; set; }
    }
}
