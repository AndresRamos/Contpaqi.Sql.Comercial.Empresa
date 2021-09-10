using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public partial class nubeCuentas
    {
        [Key]
        [StringLength(50)]
        public string CCUENTA { get; set; }

        [Required]
        [StringLength(255)]
        public string CNOMBRE { get; set; }

        public int CESTATUS { get; set; }

        public int CFLUJOEFECTIVO { get; set; }

        [Required]
        [StringLength(3)]
        public string CTIPO { get; set; }

        [Required]
        [StringLength(3)]
        public string CMONEDA { get; set; }

        public int CAFECTABLE { get; set; }

        [Required]
        [StringLength(10)]
        public string CSEGMENTO { get; set; }
    }
}