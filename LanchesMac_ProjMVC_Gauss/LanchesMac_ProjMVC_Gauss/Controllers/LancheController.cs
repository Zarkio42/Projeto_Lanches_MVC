using LanchesMac_ProjMVC_Gauss.Repositories.Interfaces;
using LanchesMac_ProjMVC_Gauss.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac_ProjMVC_Gauss.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os Lanches";

            //ViewData["Data"] = DateTime.Now;
            //var totalLanches = lanches.Count();
            //var lanches = _lancheRepository.Lanches;


            //ViewBag.Total = "Total de Lanches: ";
            //ViewBag.TotalLanches = totalLanches;

            //return View(lanches);

            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModel);
        }
    }
}
