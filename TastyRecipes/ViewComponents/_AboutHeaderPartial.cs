using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.ViewComponents
{
    public class _AboutHeaderPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutHeaderPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetList();
            return View(values);
        }
    }
}
