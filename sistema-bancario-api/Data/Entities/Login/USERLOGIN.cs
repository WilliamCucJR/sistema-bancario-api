using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_post.Data.Entities.Login
{
    [Table("USERLOGIN")]
    public class USERLOGIN
    {
       
        [Key]
        public int USERID { get; set; }
        public string? NICKNAME { get; set; }
        public string? PASSWORD { get; set; }

        public string? NOMBRES { get; set; }

        public string? APELLIDOS { get; set; }

        public string? DIRECCION { get; set; }

        public string? TELEFONO { get; set; }

        public string? EMAIL { get; set; }

        public string? FECHANACIMIENTO { get; set; }

        public string? FECHAREGISTRO { get; set; }

    }
}
