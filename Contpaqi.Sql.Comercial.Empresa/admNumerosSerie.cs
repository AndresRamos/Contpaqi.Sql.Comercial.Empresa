using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    [Table("admNumerosSerie")]
    public class admNumerosSerie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDSERIE { get; set; }

        public int CIDPRODUCTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMEROSERIE { get; set; }

        public int CIDALMACEN { get; set; }

        public int CESTADO { get; set; }

        public int CESTADOANTERIOR { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMEROLOTE { get; set; }

        public DateTime CFECHACADUCIDAD { get; set; }

        public DateTime CFECHAFABRICACION { get; set; }

        [Required]
        [StringLength(30)]
        public string CPEDIMENTO { get; set; }

        [Required]
        [StringLength(60)]
        public string CADUANA { get; set; }

        public DateTime CFECHAPEDIMENTO { get; set; }

        public double CTIPOCAMBIO { get; set; }

        public double CCOSTO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public int CNUMADUANA { get; set; }

        [Required]
        [StringLength(30)]
        public string CCLAVESAT { get; set; }
    }
}