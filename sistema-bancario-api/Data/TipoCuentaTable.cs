using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;


namespace sistema_bancario_api.Data
{
    public class TipoCuentaTable : DbContext
    {
        public TipoCuentaTable(DbContextOptions<TipoCuentaTable> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<TIPO_CUENTA> TipoCuentas {  get; set; }  
    }
}
