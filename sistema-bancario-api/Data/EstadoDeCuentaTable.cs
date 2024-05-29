using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class EstadoDeCuentaTable : DbContext
    {
        public EstadoDeCuentaTable(DbContextOptions<EstadoDeCuentaTable> options) : base(options) { }

        public DbSet<CUENTA_BANCARIA> CuentasBancarias { get; set; }
        public DbSet<MovimientoEstadoCuenta> MovimientosEstadoCuenta { get; set; }
        public DbSet<ESTADODECUENTA> EstadosDeCuenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CUENTA_BANCARIA>().HasKey(c => c.ID_CUENTA);
            modelBuilder.Entity<MovimientoEstadoCuenta>().HasKey(m => m.ID);
            modelBuilder.Entity<ESTADODECUENTA>().HasKey(e => e.ID);
            modelBuilder.Entity<MovimientoEstadoCuenta>()
                .HasOne(m => m.CuentaBancaria)
                .WithMany()
                .HasForeignKey(m => m.ID_CUENTA);
        }
    }
}
