using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class DepartamentoTable : DbContext
    {
        public DepartamentoTable(DbContextOptions<DepartamentoTable> context) : base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<DEPARTAMENTO> Deptos { get; set; }
    }
}
