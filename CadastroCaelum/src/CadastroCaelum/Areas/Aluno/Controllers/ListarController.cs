using Microsoft.AspNetCore.Mvc;

namespace CadastroCaelum.Areas.Aluno.Controllers
{
    [Area("Aluno")]
    public class ListarController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }
    }
}
