using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("MUNICIPIO")]
    public class DEPARTAMENTO
    {
        [Key]
        public int ID { get; set; }
        public string? NOMBRE_DEL_DEPARTAMENTO {  get; set; }

    }
}
