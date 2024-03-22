using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("TIPO_CUENTA")]
    public class TIPO_CUENTA
    {
        [Key]
        public int ID { get; set; }
        public string? TIPO_DE_CUENTA { get; set; }

        public string? FECHA_DE_CREACION { get; set; }
    }
}
