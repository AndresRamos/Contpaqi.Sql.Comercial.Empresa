using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public partial class admClasificaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCLASIFICACION { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBRECLASIFICACION { get; set; }
    }
}