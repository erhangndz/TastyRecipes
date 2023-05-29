using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.ViewComponents
{
    public class _DishPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
