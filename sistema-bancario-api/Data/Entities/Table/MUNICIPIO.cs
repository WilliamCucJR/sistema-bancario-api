using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("MUNICIPIO")]
    public class Municipio
    {
        [Key]
        public int ID { get; set; }

        [Column("Nombre_del_Municipio")]
        public string Nombre { get; set; }

        [Column("ID_Departamento")]
        public int DepartamentoId { get; set; }
    }
}
