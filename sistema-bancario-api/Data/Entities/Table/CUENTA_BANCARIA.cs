using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("CUENTA_BANCARIA")]
    public class CUENTA_BANCARIA
    {
        [Key]
        public int? ID_CUENTA { get; set; }
        public int? BANCO_ID { get; set; }
        public string? NO_DE_CUENTA { get; set; }
        public int? TIPO_DE_CUENTA_ID { get; set; }
        public string? NOMBRE_CUENTAHABIENTE { get; set; }
        public string? DPI {  get; set; }
        public string? NIT {  get; set; }
        public string? TELEFONO { get; set; }
        public string? CORREO { get; set; }
        public string? DIRECCION { get; set; }
        public string? ZONA { get; set; }
        public int? DEPARTAMENTO_ID { get; set; }
        public int? MUNICIPIO_ID { get; set; }
        public int? MONEDA_ID { get; set; }
        public double? SALDO { get; set; }
    }
}
