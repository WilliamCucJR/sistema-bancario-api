using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("ESTADODECUENTA")]
    public class ESTADODECUENTA
    {
        public string NumeroDocumento { get; set; }

        public string Descripcion { get; set; }

        public decimal Monto { get; set; }

        public string TipoDocumento { get; set; }

        public string Operacion { get; set; }
    }
}
