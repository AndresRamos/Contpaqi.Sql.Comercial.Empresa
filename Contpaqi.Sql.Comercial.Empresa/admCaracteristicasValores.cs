using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public class admCaracteristicasValores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDVALORCARACTERISTICA { get; set; }

        public int CIDPADRECARACTERISTICA { get; set; }

        [Required]
        [StringLength(20)]
        public string CVALORCARACTERISTICA { get; set; }

        [Required]
        [StringLength(3)]
        public string CNEMOCARACTERISTICA { get; set; }
    }
}