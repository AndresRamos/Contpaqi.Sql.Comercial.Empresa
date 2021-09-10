using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public partial class admAcumuladosTipos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDTIPOACUMULADO { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBRE { get; set; }

        public int CTIPOOWNER1 { get; set; }

        public int CTIPOOWNER2 { get; set; }

        public int CTIPOACTUALIZACION { get; set; }

        public int CTIPOMONEDA { get; set; }
    }
}