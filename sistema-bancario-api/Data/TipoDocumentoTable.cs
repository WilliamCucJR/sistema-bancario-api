using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class TipoDocumentoTable : DbContext
    {
        public TipoDocumentoTable(DbContextOptions<TipoDocumentoTable> context) : base(context) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<TIPO_DOCUMENTO> TipoDocs { get; set; }
    }
}
