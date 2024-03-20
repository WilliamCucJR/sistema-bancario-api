using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("MUNICIPIO")]
    public class MUNICIPIO
    {
        [Key]
        public int ID { get; set; }
        public string? NOMBRE_DEL_MUNICIPIO {  get; set; }
        public int? ID_DEPARTAMENTO { get; set; }
    }
}
