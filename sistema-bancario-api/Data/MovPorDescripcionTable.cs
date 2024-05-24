using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Data
{
    public class MovPorDescripcionTable : DbContext
    {
        public MovPorDescripcionTable(DbContextOptions<MovPorDescripcionTable> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<MOVPORDESCRIPCION> MovPorDesc { get; set; }
    }
}
