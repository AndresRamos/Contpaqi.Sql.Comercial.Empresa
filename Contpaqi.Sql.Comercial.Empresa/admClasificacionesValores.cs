using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public class admClasificacionesValores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDVALORCLASIFICACION { get; set; }

        [Required]
        [StringLength(60)]
        public string CVALORCLASIFICACION { get; set; }

        public int CIDCLASIFICACION { get; set; }

        [Required]
        [StringLength(3)]
        public string CCODIGOVALORCLASIFICACION { get; set; }

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