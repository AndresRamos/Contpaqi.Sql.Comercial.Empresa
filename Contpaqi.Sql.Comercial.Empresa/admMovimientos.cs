using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public partial class admMovimientos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMOVIMIENTO { get; set; }

        public int CIDDOCUMENTO { get; set; }

        public double CNUMEROMOVIMIENTO { get; set; }

        public int CIDDOCUMENTODE { get; set; }

        public int CIDPRODUCTO { get; set; }

        public int CIDALMACEN { get; set; }

        public double CUNIDADES { get; set; }

        public double CUNIDADESNC { get; set; }

        public double CUNIDADESCAPTURADAS { get; set; }

        public int CIDUNIDAD { get; set; }

        public int CIDUNIDADNC { get; set; }

        public double CPRECIO { get; set; }

        public double CPRECIOCAPTURADO { get; set; }

        public double CCOSTOCAPTURADO { get; set; }

        public double CCOSTOESPECIFICO { get; set; }

        public double CNETO { get; set; }

        public double CIMPUESTO1 { get; set; }

        public double CPORCENTAJEIMPUESTO1 { get; set; }

        public double CIMPUESTO2 { get; set; }

        public double CPORCENTAJEIMPUESTO2 { get; set; }

        public double CIMPUESTO3 { get; set; }

        public double CPORCENTAJEIMPUESTO3 { get; set; }

        public double CRETENCION1 { get; set; }

        public double CPORCENTAJERETENCION1 { get; set; }

        public double CRETENCION2 { get; set; }

        public double CPORCENTAJERETENCION2 { get; set; }

        public double CDESCUENTO1 { get; set; }

        public double CPORCENTAJEDESCUENTO1 { get; set; }

        public double CDESCUENTO2 { get; set; }

        public double CPORCENTAJEDESCUENTO2 { get; set; }

        public double CDESCUENTO3 { get; set; }

        public double CPORCENTAJEDESCUENTO3 { get; set; }

        public double CDESCUENTO4 { get; set; }

        public double CPORCENTAJEDESCUENTO4 { get; set; }

        public double CDESCUENTO5 { get; set; }

        public double CPORCENTAJEDESCUENTO5 { get; set; }

        public double CTOTAL { get; set; }

        public double CPORCENTAJECOMISION { get; set; }

        [Required]
        [StringLength(20)]
        public string CREFERENCIA { get; set; }

        [Column(TypeName = "text")]
        public string COBSERVAMOV { get; set; }

        public int CAFECTAEXISTENCIA { get; set; }

        public int CAFECTADOSALDOS { get; set; }

        public int CAFECTADOINVENTARIO { get; set; }

        public DateTime CFECHA { get; set; }

        public int CMOVTOOCULTO { get; set; }

        public int CIDMOVTOOWNER { get; set; }

        public int CIDMOVTOORIGEN { get; set; }

        public double CUNIDADESPENDIENTES { get; set; }

        public double CUNIDADESNCPENDIENTES { get; set; }

        public double CUNIDADESORIGEN { get; set; }

        public double CUNIDADESNCORIGEN { get; set; }

        public int CTIPOTRASPASO { get; set; }

        public int CIDVALORCLASIFICACION { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA3 { get; set; }

        public DateTime CFECHAEXTRA { get; set; }

        public double CIMPORTEEXTRA1 { get; set; }

        public double CIMPORTEEXTRA2 { get; set; }

        public double CIMPORTEEXTRA3 { get; set; }

        public double CIMPORTEEXTRA4 { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public double CGTOMOVTO { get; set; }

        [Required]
        [StringLength(50)]
        public string CSCMOVTO { get; set; }

        public double CCOMVENTA { get; set; }

        public int CIDMOVTODESTINO { get; set; }

        public int CNUMEROCONSOLIDACIONES { get; set; }
    }
}