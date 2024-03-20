namespace sistema_bancario_api.Data;

using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data.Entities.Table;

public class UserLoginTable : DbContext
{
   
    public UserLoginTable(DbContextOptions<UserLoginTable> context) : base(context)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<USERLOGIN> Logins { get; set; }

 

}

