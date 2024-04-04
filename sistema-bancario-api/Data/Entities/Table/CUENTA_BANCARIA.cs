using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("CUENTA_BANCARIA")]
    public class CUENTA_BANCARIA
    {
        [Key]
        private int? ID_CUENTA { get; set; }
        private int? BANCO_ID { get; set; }
        private string? NO_DE_CUENTA { get; set; }
        private int? TIPO_DE_CUENTA_ID { get; set; }
        private string? NOMBRE_CUENTAHABIENTE { get; set; }
        private string? DPI {  get; set; }
        private string? NIT {  get; set; }
        private string? TELEFONO { get; set; }
        private string? CORREO { get; set; }
        private string? DIRECCION { get; set; }
        private string? ZONA { get; set; }
        private int? DEPARTAMENTO_ID { get; set; }
        private int? MUNICIPIO_ID { get; set; }
        private int? MONEDA_ID { get; set; }
        private double? SALDO { get; set; }
    }
}
