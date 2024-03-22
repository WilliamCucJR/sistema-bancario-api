using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("TIPO_DOCUMENTO")]
    public class TIPO_DOCUMENTO
    {
        [Key]
        public int ID { get; set; }
        public string? NOMBRE_DOCUMENTO { get; set; }
        public string? DESCRIPCION { get; set; }
        public string? OPERACION { get; set; }
    }
}
