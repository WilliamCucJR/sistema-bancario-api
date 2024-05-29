using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("MOVIMIENTOS")]
    public class MovimientoEstadoCuenta
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("CUENTA_BANCARIA")]
        public int ID_CUENTA { get; set; }
        public CUENTA_BANCARIA CuentaBancaria { get; set; }

        public string Descripcion { get; set; }
        public string NoDocumento { get; set; }

        public int TipoDocumentoID { get; set; }
        public string Fecha { get; set; }

        public int Monto { get; set; }
        public string DocumentoContable { get; set; }
    }
}
