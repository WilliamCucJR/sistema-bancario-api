using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("CONCILIACION")]
    public class CONCILIACION
    {
        [Key]
        public int ID_MOVIMIENTO { get; set; }
        public int? ID_CUENTA { get; set; }
        public int? ID_DOCUMENTO { get; set; }
        public string? DESCRIPCION { get; set; }
        public DateTime? FECHA { get; set; }
        public string? NO_DOCUMENTO { get; set; }
        public int? TIPO_DOCUMENTO_ID { get; set; }
        public int? MONTO { get; set; }
        public string? DOCUMENTO_CONTABLE { get; set; }
        public string? NO_DE_CUENTA { get; set; }
        public string? OPERACION { get; set; }
        public string? NOMBRE_BANCO { get; set; }
    }
}
