using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    [Table("admMovimientosPrepoliza")]
    public partial class admMovimientosPrepoliza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMOVIMIENTOPREPOLIZA { get; set; }

        public int CIDPREPOLIZA { get; set; }

        public int EJE { get; set; }

        public int PERIODO { get; set; }

        public int TIPOPOL { get; set; }

        public int NUMPOL { get; set; }

        public int MOVTO { get; set; }

        [Required]
        [StringLength(50)]
        public string CUENTA { get; set; }

        public int TIPOMOV { get; set; }

        [Required]
        [StringLength(30)]
        public string REFERENCIA { get; set; }

        public double IMPORTE { get; set; }

        [Required]
        [StringLength(10)]
        public string DIARIO { get; set; }

        public double MONEDA { get; set; }

        [Required]
        [StringLength(100)]
        public string CONCEPTO { get; set; }

        public DateTime FECHA { get; set; }

        [Required]
        [StringLength(10)]
        public string SEGNEG { get; set; }
    }
}