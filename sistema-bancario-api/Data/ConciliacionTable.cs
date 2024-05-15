using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class ConciliacionTable : DbContext
    {
        public ConciliacionTable(DbContextOptions<ConciliacionTable> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CONCILIACION> Conciliacion { get; set; }
    }
}
