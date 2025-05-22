using Microsoft.EntityFrameworkCore;
using SlappyApi.DTO;

namespace SlappyApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Carta> Cartas { get; set; }
        public DbSet<CartaMazo> CartasMazos { get; set; }

        // public DbSet<Mazo> Mazos { get; set; }

    }
}
