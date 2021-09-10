using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    [Table("admComponentesPaquete")]
    public partial class admComponentesPaquete
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCOMPONENTE { get; set; }

        public int CIDPAQUETE { get; set; }

        public int CIDPRODUCTO { get; set; }

        public double CCANTIDADPRODUCTO { get; set; }

        public int CIDVALORCARACTERISTICA1 { get; set; }

        public int CIDVALORCARACTERISTICA2 { get; set; }

        public int CIDVALORCARACTERISTICA3 { get; set; }

        public int CTIPOPRODUCTO { get; set; }

        public int CIDUNIDADVENTA { get; set; }
    }
}