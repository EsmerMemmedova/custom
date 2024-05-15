using Microsoft.AspNetCore.Mvc;

namespace WebPustok.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
