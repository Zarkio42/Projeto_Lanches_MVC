using LanchesMac_ProjMVC_Gauss.Models;

namespace LanchesMac_ProjMVC_Gauss.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
