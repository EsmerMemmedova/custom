using doorang.Business.Services.Abstracts;
using doorang.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace doorangweb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExploreController : Controller
    {
      
        private readonly IExploreService _exploreService;
       
        public ExploreController(IExploreService exploreService)
        {
            _exploreService = exploreService;
        }

        public IActionResult Index()
        {
            List <Explore> explore=_exploreService.GetAllExplore();
            return View(explore);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Explore explore )
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            _exploreService.AddExplore(explore);
            
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id,Explore newexplore)
        {
            _exploreService.UpdateExplore(id, newexplore);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            
           _exploreService.RemoveExplore(id);
            return RedirectToAction("Index");
        }
    }
}
        
    

