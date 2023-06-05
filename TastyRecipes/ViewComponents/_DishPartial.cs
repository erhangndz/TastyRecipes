using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.ViewComponents
{
    public class _DishPartial:ViewComponent
    {
        private readonly IDishService _dishService;

        public _DishPartial(IDishService dishService)
        {
            _dishService = dishService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _dishService.TGetList();
            return View(values);
        }
    }
}
