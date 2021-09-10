using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public partial class admCaracteristicas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPADRECARACTERISTICA { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBRECARACTERISTICA { get; set; }
    }
}