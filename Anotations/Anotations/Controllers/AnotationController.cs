using Microsoft.AspNetCore.Mvc;

namespace Anotations.Controllers
{
    public class AnotationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
