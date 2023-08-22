using JC_ViaBrasil.Data.Map;
using JC_ViaBrasil.Models;
using Microsoft.EntityFrameworkCore;

namespace JC_ViaBrasil.Data
{
    public class TabelaFipeDbContext : DbContext
    {
        public TabelaFipeDbContext(DbContextOptions<TabelaFipeDbContext> options) : base(options) { }

        public DbSet<TabelaFipe> TabelaFipe { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TabelaFipeMap());
        }
    }
}
