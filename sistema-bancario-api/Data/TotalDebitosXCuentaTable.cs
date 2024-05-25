using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class TotalDebitosXCuentaTable : DbContext
    {
        public TotalDebitosXCuentaTable(DbContextOptions<TotalDebitosXCuentaTable> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<TOTALDEBITOSXCUENTA> TotDebs { get; set; }
    }
}
