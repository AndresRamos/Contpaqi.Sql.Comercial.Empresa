using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Comercial.Empresa
{
    public partial class admConceptos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCONCEPTODOCUMENTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CCODIGOCONCEPTO { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBRECONCEPTO { get; set; }

        public int CIDDOCUMENTODE { get; set; }

        public int CNATURALEZA { get; set; }

        public int CDOCTOACREDITO { get; set; }

        public int CTIPOFOLIO { get; set; }

        public int CMAXIMOMOVTOS { get; set; }

        public int CCREACLIENTE { get; set; }

        public int CSUMARPROMOCIONES { get; set; }

        [Required]
        [StringLength(253)]
        public string CFORMAPREIMPRESA { get; set; }

        public int CORDENCALCULO { get; set; }

        public int CUSANOMBRECTEPROV { get; set; }

        public int CUSARFC { get; set; }

        public int CUSAFECHAVENCIMIENTO { get; set; }

        public int CUSAFECHAENTREGARECEPCION { get; set; }

        public int CUSAMONEDA { get; set; }

        public int CUSATIPOCAMBIO { get; set; }

        public int CUSACODIGOAGENTE { get; set; }

        public int CUSANOMBREAGENTE { get; set; }

        public int CUSADIRECCION { get; set; }

        public int CUSAREFERENCIA { get; set; }

        [Required]
        [StringLength(11)]
        public string CSERIEPOROMISION { get; set; }

        public int CANCHOCODIGOPRODUCTO { get; set; }

        public int CUSANOMBREPRODUCTO { get; set; }

        public int CANCHONOMBREPRODUCTO { get; set; }

        public int CUSAALMACEN { get; set; }

        public int CANCHOCODIGOALMACEN { get; set; }

        public int CANCHOIMPORTES { get; set; }

        public int CANCHOPORCENTAJES { get; set; }

        public int CANCHOUNIDADPESOMEDIDA { get; set; }

        public int CUSAPRECIO { get; set; }

        public int CIDFORMULAPRECIO { get; set; }

        public int CUSACOSTOCAPTURADO { get; set; }

        public int CIDFORMULACOSTOCAPTURADO { get; set; }

        public int CUSAEXISTENCIA { get; set; }

        public int CUSANETO { get; set; }

        public int CIDFORMULANETO { get; set; }

        public int CUSAPORCENTAJEIMPUESTO1 { get; set; }

        public int CIDFORMULAPORCIMPUESTO1 { get; set; }

        public int CUSAIMPUESTO1 { get; set; }

        public int CIDFORMULAIMPUESTO1 { get; set; }

        public int CUSAPORCENTAJEIMPUESTO2 { get; set; }

        public int CIDFORMULAPORCIMPUESTO2 { get; set; }

        public int CUSAIMPUESTO2 { get; set; }

        public int CIDFORMULAIMPUESTO2 { get; set; }

        public int CUSAPORCENTAJEIMPUESTO3 { get; set; }

        public int CIDFORMULAPORCIMPUESTO3 { get; set; }

        public int CUSAIMPUESTO3 { get; set; }

        public int CIDFORMULAIMPUESTO3 { get; set; }

        public int CUSAPORCENTAJERETENCION1 { get; set; }

        public int CIDFORMULAPORCRETENCION1 { get; set; }

        public int CUSARETENCION1 { get; set; }

        public int CIDFORMULARETENCION1 { get; set; }

        public int CUSAPORCENTAJERETENCION2 { get; set; }

        public int CIDFORMULAPORCRETENCION2 { get; set; }

        public int CUSARETENCION2 { get; set; }

        public int CIDFORMULARETENCION2 { get; set; }

        public int CUSAPORCENTAJEDESCUENTO1 { get; set; }

        public int CIDFORMULAPORCDESCUENTO1 { get; set; }

        public int CUSADESCUENTO1 { get; set; }

        public int CIDFORMULADESCUENTO1 { get; set; }

        public int CUSAPORCENTAJEDESCUENTO2 { get; set; }

        public int CIDFORMULAPORCDESCUENTO2 { get; set; }

        public int CUSADESCUENTO2 { get; set; }

        public int CIDFORMULADESCUENTO2 { get; set; }

        public int CUSAPORCENTAJEDESCUENTO3 { get; set; }

        public int CIDFORMULAPORCDESCUENTO3 { get; set; }

        public int CUSADESCUENTO3 { get; set; }

        public int CIDFORMULADESCUENTO3 { get; set; }

        public int CUSAPORCENTAJEDESCUENTO4 { get; set; }

        public int CIDFORMULAPORCDESCUENTO4 { get; set; }

        public int CUSADESCUENTO4 { get; set; }

        public int CIDFORMULADESCUENTO4 { get; set; }

        public int CUSAPORCENTAJEDESCUENTO5 { get; set; }

        public int CIDFORMULAPORCDESCUENTO5 { get; set; }

        public int CUSADESCUENTO5 { get; set; }

        public int CIDFORMULADESCUENTO5 { get; set; }

        public int CUSATOTAL { get; set; }

        public int CANCHOREFERENCIA { get; set; }

        public int CUSACLASIFICACIONMOVTO { get; set; }

        public int CANCHOVALORCLASIFICACION { get; set; }

        public int CIDFORMULATOTAL { get; set; }

        public int CUSADESCUENTODOC1 { get; set; }

        public int CIDFORMULADESDOC1 { get; set; }

        public int CUSADESCUENTODOC2 { get; set; }

        public int CIDFORMULADESDOC2 { get; set; }

        public int CUSAGASTO1 { get; set; }

        public int CIDFORMULAGASTO1 { get; set; }

        public int CUSAGASTO2 { get; set; }

        public int CIDFORMULAGASTO2 { get; set; }

        public int CUSAGASTO3 { get; set; }

        public int CIDFORMULAGASTO3 { get; set; }

        public int CUSATEXTOEXTRA1 { get; set; }

        public int CUSATEXTOEXTRA2 { get; set; }

        public int CUSATEXTOEXTRA3 { get; set; }

        public int CANCHOTEXTOEXTRA { get; set; }

        public int CUSAFECHAEXTRA { get; set; }

        public int CANCHOFECHAEXTRA { get; set; }

        public int CUSAIMPORTEEXTRA1 { get; set; }

        public int CIDFORMULAEXTRA1 { get; set; }

        public int CUSAIMPORTEEXTRA2 { get; set; }

        public int CIDFORMULAEXTRA2 { get; set; }

        public int CUSAIMPORTEEXTRA3 { get; set; }

        public int CIDFORMULAEXTRA3 { get; set; }

        public int CUSAIMPORTEEXTRA4 { get; set; }

        public int CIDFORMULAEXTRA4 { get; set; }

        public int CUSATEXTOEXTRA1DOC { get; set; }

        public int CUSATEXTOEXTRA2DOC { get; set; }

        public int CUSATEXTOEXTRA3DOC { get; set; }

        public int CUSAFECHAEXTRADOC { get; set; }

        public int CUSAIMPORTEEXTRA1DOC { get; set; }

        public int CUSAIMPORTEEXTRA2DOC { get; set; }

        public int CUSAIMPORTEEXTRA3DOC { get; set; }

        public int CUSAIMPORTEEXTRA4DOC { get; set; }

        public int CUSAEXTRACOMOGASTO { get; set; }

        public int CUSAOBSERVACIONES { get; set; }

        public int CPRESENTAFISCAL { get; set; }

        public int CPRESENTAREFERENCIA { get; set; }

        public int CPRESENTACONDICIONES { get; set; }

        public int CPRESENTAENVIO { get; set; }

        public int CPRESENTADETALLE { get; set; }

        public int CPRESENTAIMPRIMIR { get; set; }

        public int CPRESENTAPAGAR { get; set; }

        public int CPRESENTASALDAR { get; set; }

        public int CPRESENTADOCUMENTAR { get; set; }

        public int CPRESENTAGASTOSCOMPRA { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTCONCEPTO { get; set; }

        public int CBANENCABEZADO { get; set; }

        public int CBANMOVIMIENTO { get; set; }

        public int CBANDESCUENTO { get; set; }

        public int CBANIMPUESTO { get; set; }

        public int CBANACCIONAUTOMATICA { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public double CNOFOLIO { get; set; }

        public int CIDPROCESOSEGURIDAD { get; set; }

        public int CUSAGTOMOV { get; set; }

        public int CUSASCMOV { get; set; }

        public int CIDASTOCON { get; set; }

        [Required]
        [StringLength(50)]
        public string CSCCPTO2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSCCPTO3 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSCMOVTO { get; set; }

        public int CIDCONAUTO { get; set; }

        public int CIDALMASUM { get; set; }

        public int CUSACOMVTA { get; set; }

        public int CIDPRSEG02 { get; set; }

        public int CIDPRSEG03 { get; set; }

        public int CIDPRSEG04 { get; set; }

        public int CIDPRSEG05 { get; set; }

        public int CFORMAAJ01 { get; set; }

        public int CIDPRSEG06 { get; set; }

        public int CAPFORMULA { get; set; }

        public int CESCFD { get; set; }

        public int CIDFIRMARL { get; set; }

        public int CGDAPASSW { get; set; }

        public int CEMITEYENT { get; set; }

        public int CBANCFD { get; set; }

        [Required]
        [StringLength(253)]
        public string CREPIMPCFD { get; set; }

        public int CIDDIRSUCU { get; set; }

        public int CBANDIRSUC { get; set; }

        public int CVERFACELE { get; set; }

        public int CCALFECHAS { get; set; }

        public int CTIPCAMTR1 { get; set; }

        public int CTIPCAMTR2 { get; set; }

        public int CCONSOLIDA { get; set; }

        public int CENVIODIG { get; set; }

        public int CBANTRANS { get; set; }

        public int CCONFNOAPR { get; set; }

        public int CNOAPROB { get; set; }

        public int CAUTOIMPR { get; set; }

        public int CRECIBECFD { get; set; }

        public int CSISTORIG { get; set; }

        public int CIDCPTODE1 { get; set; }

        public int CIDCPTODE2 { get; set; }

        public int CIDCPTODE3 { get; set; }

        [Required]
        [StringLength(253)]
        public string CPLAMIGCFD { get; set; }

        public int CIDPRSEG07 { get; set; }

        public int CRESERVADO { get; set; }

        public int CVERREFER { get; set; }

        public int CVERDOCORI { get; set; }

        public int CCBB { get; set; }

        public int CCARTAPOR { get; set; }

        public int CCOMPDONAT { get; set; }

        public int COBSXML { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTAENTREGA { get; set; }

        [Required]
        [StringLength(30)]
        public string CPREFIJOCONCEPTO { get; set; }

        [Required]
        [StringLength(100)]
        public string CREGIMFISC { get; set; }

        public int CCOMPEDUCA { get; set; }

        [Required]
        [StringLength(100)]
        public string CMETODOPAG { get; set; }

        [Required]
        [StringLength(6)]
        public string CVERESQUE { get; set; }

        [Required]
        [StringLength(40)]
        public string CIDFIRMADSL { get; set; }

        [Required]
        [StringLength(52)]
        public string CORDENCAPTURA { get; set; }

        public int CESTATUS { get; set; }

        public int CIDMONEDA { get; set; }

        public int CIDCUENTA { get; set; }

        [Required]
        [StringLength(8)]
        public string CCLAVESAT { get; set; }

        public int CIDPRSEG08 { get; set; }
    }
}