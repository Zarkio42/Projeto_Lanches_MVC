using LanchesMac_ProjMVC_Gauss.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac_ProjMVC_Gauss.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}
