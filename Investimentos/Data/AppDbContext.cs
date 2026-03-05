using Microsoft.EntityFrameworkCore;

namespace Investimentos.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Models.CotacaoModel> Cotacao { get; set; }
    }
}
