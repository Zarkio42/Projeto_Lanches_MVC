using LanchesMac_ProjMVC_Gauss.Models;
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

        public IActionResult List(string categoria)
        {
            //ViewData["Titulo"] = "Todos os Lanches";

            //ViewData["Data"] = DateTime.Now;
            //var totalLanches = lanches.Count();
            //var lanches = _lancheRepository.Lanches;


            //ViewBag.Total = "Total de Lanches: ";
            //ViewBag.TotalLanches = totalLanches;

            //return View(lanches);

            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if(string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                        .OrderBy(l => l.NameLanche);
                }
                else
                {
                    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                        .OrderBy(l => l.NameLanche);
                }
                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        }
    }
}
