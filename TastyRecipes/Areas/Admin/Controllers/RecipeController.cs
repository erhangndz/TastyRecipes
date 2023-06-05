using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace TastyRecipes.Areas.Admin.Controllers
{
    [Area("Admin")]
 
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            var values= _recipeService.TGetRecipewithCategory();
            return View(values);
        }

        public IActionResult DeleteRecipe(int id)
        {
            var values= _recipeService.TGetByID(id);
            _recipeService.TDelete(values);
            return RedirectToAction("Recipe", "Admin");
        }

        [HttpGet]
        public IActionResult UpdateRecipe(int id) 
        {
            List<SelectListItem> category =(from x in _recipeService.TGetRecipewithCategory()
                                             select new SelectListItem
                                             {
                                                 Text=x.RecipeCategory.RecipeCategoryName,
                                                 Value=x.RecipeCategoryID.ToString()
                                             }).ToList();
            ViewBag.category=category;
            var values = _recipeService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateRecipe(Recipe p)
        {
            List<SelectListItem> category = (from x in _recipeService.TGetRecipewithCategory()
                                             select new SelectListItem
                                             {
                                                 Text = x.RecipeCategory.RecipeCategoryName,
                                                 Value = x.RecipeCategoryID.ToString()
                                             }).ToList();
            ViewBag.category = category;
            _recipeService.TUpdate(p);
            return RedirectToAction("Recipe","Admin");
        }

        [HttpGet]
        public IActionResult AddRecipe()
        {
            List<SelectListItem> category = (from x in _recipeService.TGetRecipewithCategory()
                                             select new SelectListItem
                                             {
                                                 Text = x.RecipeCategory.RecipeCategoryName,
                                                 Value = x.RecipeCategoryID.ToString()
                                             }).ToList();
            ViewBag.category = category;
            return View();
        }
        [HttpPost]
        public IActionResult AddRecipe(Recipe p)
        {
            List<SelectListItem> category = (from x in _recipeService.TGetRecipewithCategory()
                                             select new SelectListItem
                                             {
                                                 Text = x.RecipeCategory.RecipeCategoryName,
                                                 Value = x.RecipeCategoryID.ToString()
                                             }).ToList();
            ViewBag.category = category;
            _recipeService.TInsert(p);
            return RedirectToAction("Recipe", "Admin");
        }

    }
}
