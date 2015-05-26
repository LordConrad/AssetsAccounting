using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    [Table("Responsibles")]
    public class Responsible
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Position { get; set; }
        public string AuthorityNumber { get; set; }

        [ForeignKey("ResponsibleId")]
        public IEnumerable<ResponsiblesAssets> ResponsiblesAssets { get; set; }

    }
}
