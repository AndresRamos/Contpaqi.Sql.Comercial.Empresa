using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    [Table("admTiposCambio")]
    public partial class admTiposCambio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDTIPOCAMBIO { get; set; }

        public int CIDMONEDA { get; set; }

        public DateTime CFECHA { get; set; }

        public double CIMPORTE { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }
    }
}