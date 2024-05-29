using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class EstadoDeCuentaTable : DbContext
    {
        public EstadoDeCuentaTable(DbContextOptions<EstadoDeCuentaTable> options) : base(options) { }

        public DbSet<ESTADODECUENTA> EstadosDeCuenta { get; set; }
        public DbSet<MovimientoEstadoCuenta> MovimientosEstadoCuenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ESTADODECUENTA>()
                .HasKey(e => e.ID);

            modelBuilder.Entity<MovimientoEstadoCuenta>()
                .HasKey(m => m.ID);

            modelBuilder.Entity<MovimientoEstadoCuenta>()
                .HasOne(m => m.EstadoDeCuenta)
                .WithMany(e => e.Movimientos)
                .HasForeignKey(m => m.EstadoDeCuentaID);
        }
    }
}
