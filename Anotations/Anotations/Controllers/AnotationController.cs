using Anotations.Context;
using Anotations.Repository;
using Anotations.Repository.Interfaces;
using Anotations.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Anotations.Controllers
{
    public class AnotationController : Controller
    {
        //instancia do repositório que tem acesso ao contexto, pois iremos utilizar dados do banco
        //sempre que formos definir o tipo de algo do container Di, usar o tipo base
        private readonly IAnotationRepository _anotationRepository;
        public AnotationController(IAnotationRepository anotationRepository)
        {
            _anotationRepository = anotationRepository;
        }

        public IActionResult Index()
        {
            var data = new AnotationsViewModel { Anotations = _anotationRepository.GetAnotations };
            return View(data);
        }
    }
}
