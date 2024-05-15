using Microsoft.AspNetCore.Mvc;

namespace WebApplicationinance.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
