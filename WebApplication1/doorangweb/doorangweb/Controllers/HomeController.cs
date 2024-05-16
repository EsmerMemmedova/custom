
using doorang.Business.Services.Abstracts;
using doorang.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace doorangweb.Controllers
{
    public class HomeController : Controller
    {
       IExploreService _exploreService;

        public HomeController(IExploreService exploreService)
        {
            _exploreService = exploreService;
        }

        public IActionResult Index()
        {
            
            return View(_exploreService.GetAllExplore());
            
        }

        
    }
}