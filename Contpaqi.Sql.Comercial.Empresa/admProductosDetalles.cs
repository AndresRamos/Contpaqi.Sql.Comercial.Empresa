using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public class admProductosDetalles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPRODUCTO { get; set; }

        public int CTIPOPRODUCTO { get; set; }

        public int CIDPRODUCTOPADRE { get; set; }

        public int CIDVALORCARACTERISTICA1 { get; set; }

        public int CIDVALORCARACTERISTICA2 { get; set; }

        public int CIDVALORCARACTERISTICA3 { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }
    }
}