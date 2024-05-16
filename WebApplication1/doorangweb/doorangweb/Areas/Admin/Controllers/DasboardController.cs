using doorang.Business.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace doorangweb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DasboardController : Controller
    {
        private readonly IExploreService _exploreService;
        public DasboardController(IExploreService exploreService)
        {
            _exploreService = exploreService;
        }

        public IActionResult Index()
        {
            return View(_exploreService.GetAllExplore());
        }
    }
}
