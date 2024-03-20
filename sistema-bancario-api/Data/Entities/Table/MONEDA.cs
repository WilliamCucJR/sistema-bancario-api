using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("MONEDA")]
    public class MONEDA
    {
        [Key]
        public int ID { get; set; }
        public string? TIPO_MONEDA { get; set; }
        public double? TASA_DE_CAMBIO { get; set; }
    }
}
