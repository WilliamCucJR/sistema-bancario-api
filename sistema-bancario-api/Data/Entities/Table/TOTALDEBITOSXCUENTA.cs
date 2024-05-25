using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("TOTALDEBITOSXCUENTA")]
    [Keyless]
    public class TOTALDEBITOSXCUENTA
    {
        public string? NO_DE_CUENTA {  get; set; }

        public string? NOMBRE_BANCO {  get; set; }

        public int? TOTAL_DEBITOS {  get; set; }
    }
}
