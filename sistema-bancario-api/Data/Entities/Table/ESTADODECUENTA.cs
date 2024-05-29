using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("ESTADO_DE_CUENTA")]
    public class ESTADODECUENTA
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("CUENTA_BANCARIA")]
        public int ID_CUENTA { get; set; }
        public CUENTA_BANCARIA CuentaBancaria { get; set; }

        public int Mes { get; set; }
        public int Anio { get; set; }

        public ICollection<MovimientoEstadoCuenta> Movimientos { get; set; }
    }

    public class MovimientoEstadoCuenta
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ESTADO_DE_CUENTA")]
        public int EstadoDeCuentaID { get; set; }
        public ESTADODECUENTA EstadoDeCuenta { get; set; }

        public string Descripcion { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoOperacion { get; set; }
    }
}

