using Microsoft.AspNetCore.Mvc;

namespace Speko.Backend.Controllers
{
    public class ProcessingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
