using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace TastyRecipes.Controllers
{
    public class AboutController : Controller
    {
       

        public IActionResult Index()
        {
            
            return View();
        }

        
    }
}
