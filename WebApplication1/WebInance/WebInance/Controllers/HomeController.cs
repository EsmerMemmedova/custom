using Microsoft.AspNetCore.Mvc;

namespace WebInance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
