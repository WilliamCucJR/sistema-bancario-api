using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("MONEDA")]
    public class MONEDA
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("TIPO_MONEDA")]
        public string? TIPO_MONEDA { get; set; }

        [Column("TASA_DE_CAMBIO")]
        public double? TASA_DE_CAMBIO { get; set; }
    }
}
