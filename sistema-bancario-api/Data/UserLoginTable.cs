namespace sistema_bancario_post.Data;

using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;
using sistema_bancario_post.Data.Entities.Login;

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

