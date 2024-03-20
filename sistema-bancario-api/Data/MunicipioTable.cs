using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class MunicipioTable : DbContext
    {
        public MunicipioTable(DbContextOptions<MunicipioTable> context) : base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<MUNICIPIO> Munis { get; set; }
    }
}
