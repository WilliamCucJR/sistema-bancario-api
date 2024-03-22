using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("USERLOGIN")]
    public class USERLOGIN
    {
       
        [Key]
        public int USERID { get; set; }
        public string? NICKNAME { get; set; }
        public string? PASSWORD { get; set; }

        public string? PRIMER_NOMBRE { get; set; }

        public string? PRIMER_APELLIDO { get; set; }

        public string? SEGUNDO_NOMBRE { get; set; }

        public string? SEGUNDO_APELLIDO { get; set; }
        public string? DIRECCION { get; set; }

        public int? TELEFONO { get; set; }

        public string? EMAIL { get; set; }

        public string? FECHANACIMIENTO { get; set; }

        public string? FECHAREGISTRO { get; set; }

        public string? SEXO { get; set; }   
        public int? DPI { get; set; }
        public int? NIT {  get; set; }
        public int? CELULAR { get; set; }
        public int? ZONA { get; set; }
        public int? ID_DEPARTAMENTO { get; set; }
        public int? ID_MUNICIPIO { get; set; }
        public string? NIVEL_ACADEMICO { get; set; }
        public string? DEPARTAMENTO_SISTEMA { get; set; }
        public string? PUESTO {  get; set; }
        public string? FECHA_INGRESO { get; set; }

    }
}
