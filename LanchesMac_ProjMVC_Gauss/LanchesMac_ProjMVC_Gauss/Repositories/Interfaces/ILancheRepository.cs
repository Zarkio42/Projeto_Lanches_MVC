using LanchesMac_ProjMVC_Gauss.Models;

namespace LanchesMac_ProjMVC_Gauss.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);


    }
}
