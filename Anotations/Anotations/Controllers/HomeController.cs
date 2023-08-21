using Anotations.Models;
using Anotations.Repository.Interfaces;
using Anotations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Anotations.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnotationRepository _anotationRepository;
        public HomeController(IAnotationRepository anotationRepository)
        {
            _anotationRepository = anotationRepository;
        }

        //instancia do repositório que tem acesso ao contexto, pois iremos utilizar dados do banco
        //sempre que formos definir o tipo de algo do container Di, usar o tipo base

        public IActionResult Index()
        {
            ViewData["teste"] = "hello world";
            var data = new AnotationsViewModel { Anotations = _anotationRepository.GetAnotations };
            return View(data);
        }

        public IActionResult Privacy()
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