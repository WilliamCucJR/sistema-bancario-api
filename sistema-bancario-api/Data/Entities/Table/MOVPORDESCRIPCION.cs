﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistema_bancario_api.Data.Entities.Table
{
    [Table("MOVPORDESCRIPCION")]
    [Keyless]
    public class MOVPORDESCRIPCION
    {
        public string? NOMBRE_DOCUMENTO { get; set; }
        public int? MONTO { get; set; }

    }
}
