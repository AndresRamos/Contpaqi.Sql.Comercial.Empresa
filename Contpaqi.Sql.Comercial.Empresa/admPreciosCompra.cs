using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    [Table("admPreciosCompra")]
    public class admPreciosCompra
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPRODUCTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPROVEEDOR { get; set; }

        public double CPRECIOCOMPRA { get; set; }

        public int CIDMONEDA { get; set; }

        [Required]
        [StringLength(20)]
        public string CCODIGOPRODUCTOPROVEEDOR { get; set; }

        public int CIDUNIDAD { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }
    }
}