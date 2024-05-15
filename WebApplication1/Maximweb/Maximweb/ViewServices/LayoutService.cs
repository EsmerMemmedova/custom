using Microsoft.AspNetCore.Mvc;

namespace Maximweb.ViewServices
{
    public class LayoutService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
