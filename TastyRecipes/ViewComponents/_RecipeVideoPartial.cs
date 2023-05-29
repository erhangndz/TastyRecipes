using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.ViewComponents
{
    public class _RecipeVideoPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
