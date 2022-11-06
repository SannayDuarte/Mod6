
using Microsoft.EntityFrameworkCore;
using RibeirinhoViagem.Model;

namespace RibeirinhoViagem.DtCont
{
    public class DbContextMod5 : DbContext
    {
        public DbContextMod5(DbContextOptions<DbContextMod5> options) : base(options)
            {


        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Destino> Destino { get; set; }
        public DbSet<Passagem> Passagem { get; set; }
    }
}
