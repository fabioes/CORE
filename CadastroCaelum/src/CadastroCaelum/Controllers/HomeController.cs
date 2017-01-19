using Microsoft.AspNetCore.Mvc;

namespace CadastroCaelum.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            ViewBag.Title = "Caelum";
            return View();
        }
    }
}
