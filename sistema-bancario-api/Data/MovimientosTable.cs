using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class MovimientosTable : DbContext
    {
        public MovimientosTable(DbContextOptions<MovimientosTable> context) : base(context) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<MOVIMIENTOS> Moves { get; set; }
    }
}
