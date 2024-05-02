using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class CuentaBancariaTable : DbContext
    {
        public CuentaBancariaTable(DbContextOptions<CuentaBancariaTable> context) : base(context) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CUENTA_BANCARIA> Bancs { get; set; }
    }
}
