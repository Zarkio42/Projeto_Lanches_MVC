using LanchesMac_ProjMVC_Gauss.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanchesMac_ProjMVC_Gauss.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}