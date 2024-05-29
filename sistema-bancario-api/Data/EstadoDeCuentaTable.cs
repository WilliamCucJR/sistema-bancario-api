using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class EstadoDeCuentaTable : DbContext
    {
        public EstadoDeCuentaTable(DbContextOptions<EstadoDeCuentaTable> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ESTADODECUENTA> EstadoDeCuenta { get; set; }
    }
}
