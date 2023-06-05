using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TastyRecipes.ViewComponents
{
    public class _ContactInfo:ViewComponent
    {
        private readonly IContactInfoService _contactInfoService;

        public _ContactInfo(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public IViewComponentResult Invoke()
        {
            var values= _contactInfoService.TGetList();
            return View(values);
        }
    }
}
