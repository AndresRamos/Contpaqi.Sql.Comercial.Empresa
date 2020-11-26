using System.ComponentModel.DataAnnotations;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public class nubeDiarios
    {
        [Key]
        [StringLength(12)]
        public string CCODIGO { get; set; }

        [Required]
        [StringLength(255)]
        public string CNOMBRE { get; set; }

        public int CTIPO { get; set; }
    }
}