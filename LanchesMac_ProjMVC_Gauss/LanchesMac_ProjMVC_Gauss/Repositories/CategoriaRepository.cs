using LanchesMac_ProjMVC_Gauss.Context;
using LanchesMac_ProjMVC_Gauss.Models;
using LanchesMac_ProjMVC_Gauss.Repositories.Interfaces;

namespace LanchesMac_ProjMVC_Gauss.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
