using Microsoft.AspNetCore.Mvc;

namespace Speko.Backend.Controllers
{
    public class TranscriptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
