using Microsoft.AspNetCore.Mvc;

namespace WebInance.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
