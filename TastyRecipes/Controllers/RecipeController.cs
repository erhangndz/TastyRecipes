using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TastyRecipes.Controllers
{
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

        public IActionResult RecipeDetails(int id) 
        {
            var values = _recipeService.TGetRecipewithCategory().Find(x=>x.RecipeID==id);
            return View(values);
        }
    }
}
