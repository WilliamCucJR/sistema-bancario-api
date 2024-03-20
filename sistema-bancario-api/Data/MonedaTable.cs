using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;


namespace sistema_bancario_api.Data
{
    public class MonedaTable : DbContext
    {
        public MonedaTable(DbContextOptions<MonedaTable> context) : base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<MONEDA> Monedas { get; set; }
    }
}
