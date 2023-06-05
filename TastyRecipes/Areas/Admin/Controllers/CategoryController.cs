using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IRecipeCategoryService _recipeCategoryService;

        public CategoryController(IRecipeCategoryService recipeCategoryService)
        {
            _recipeCategoryService = recipeCategoryService;
        }

        public IActionResult Index()
        { 
            var values= _recipeCategoryService.TGetList();
            return View(values);

        }
    }
}
