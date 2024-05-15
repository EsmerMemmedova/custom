using Microsoft.AspNetCore.Mvc;

namespace WebInance.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
