using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("CASHFLOW")]
    [Keyless]
    public class CASHFLOW
    {
        public string? NO_DE_CUENTA {  get; set; }
        public string? NOMBRE_BANCO { get; set; }
        public string? TIPO_DE_CUENTA { get; set; }
        public double? SALDO {  get; set; }
    }
}
