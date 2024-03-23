using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("BANCO")]
    public class BANCO
    {
        [Key]
        public int ID_BANCO { get; set; }
        public string? NOMBRE_BANCO { get; set; }
        public string? FECHA_DE_CREACION { get; set; }
        public int? ID_USUARIO { get; set; }
    }
}
