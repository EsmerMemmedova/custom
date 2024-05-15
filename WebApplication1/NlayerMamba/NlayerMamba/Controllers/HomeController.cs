using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace NlayerMamba.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

       
    }
}