using LanchesMac_ProjMVC_Gauss.Models;

namespace LanchesMac_ProjMVC_Gauss.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
