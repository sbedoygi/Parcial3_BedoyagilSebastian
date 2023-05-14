using Microsoft.AspNetCore.Mvc;

namespace Sebas_lavadero.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
