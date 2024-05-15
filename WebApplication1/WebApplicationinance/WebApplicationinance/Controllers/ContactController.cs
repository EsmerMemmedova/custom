using Microsoft.AspNetCore.Mvc;

namespace WebApplicationinance.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
