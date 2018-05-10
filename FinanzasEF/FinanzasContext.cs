using Microsoft.EntityFrameworkCore;
using FinanzasDomain;

namespace FinanzasEF
{
    public class FinanzasContext : DbContext
    {
        public FinanzasContext(DbContextOptions<FinanzasContext> options) : base(options)
        {
        }

        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
        }
    }
}