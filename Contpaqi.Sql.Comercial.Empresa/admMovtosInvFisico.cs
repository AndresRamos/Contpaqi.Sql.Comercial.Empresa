using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    [Table("admMovtosInvFisico")]
    public partial class admMovtosInvFisico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMOVIMIENTO { get; set; }

        public int CIDPRODUCTO { get; set; }

        public int CIDALMACEN { get; set; }

        public int CIDUNIDAD { get; set; }

        public double CUNIDADES { get; set; }

        public double CUNIDADESNC { get; set; }

        public double CUNIDADESCAPTURADAS { get; set; }

        public int CMOVTOOCULTO { get; set; }

        public int CIDMOVTOOWNER { get; set; }
    }
}