using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.ViewComponents
{
    public class _RecipePartial:ViewComponent
    {
        private readonly IRecipeService _recipeService;

        public _RecipePartial(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IViewComponentResult Invoke()
        {
            var values= _recipeService.TGetRecipewithCategory();
            return View(values);
        }
    }
}
