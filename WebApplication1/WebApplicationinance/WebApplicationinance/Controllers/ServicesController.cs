using Microsoft.AspNetCore.Mvc;

namespace WebApplicationinance.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
