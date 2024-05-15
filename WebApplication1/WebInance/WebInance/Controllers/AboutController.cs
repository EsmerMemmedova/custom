using Microsoft.AspNetCore.Mvc;

namespace WebInance.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
