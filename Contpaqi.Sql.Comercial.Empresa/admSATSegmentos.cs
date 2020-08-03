using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public class admSATSegmentos
    {
        [Key]
        [StringLength(10)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(152)]
        public string CDESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT3 { get; set; }
    }
}