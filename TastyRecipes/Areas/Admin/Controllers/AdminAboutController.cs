using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class AdminAboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AdminAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About p)
        {
            _aboutService.TUpdate(p);
            return RedirectToAction("AdminAbout","Admin");
        }
    }
}
