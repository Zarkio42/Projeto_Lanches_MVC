using LanchesMac_ProjMVC_Gauss.Context;
using LanchesMac_ProjMVC_Gauss.Models;
using LanchesMac_ProjMVC_Gauss.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac_ProjMVC_Gauss.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
