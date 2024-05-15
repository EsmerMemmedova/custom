using Maximweb.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Maximweb.Areas.manage.Controllers
{
    [Area("manage")]
    public class ServiceController : Controller
    {
      private readonly  AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        //public async Task<IActionResult> Create(Service service)
        //{
        //if(!service.PhotoFile.ContentType.Contains("image/")

        //            ModelState
        //}
    }
}
