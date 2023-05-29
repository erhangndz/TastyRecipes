using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Title { get; set; }
        public string TimeNeed { get; set; }
        public string Image { get; set; }
        public string IngredientName { get; set; }
        public string Process { get; set; }
        public int RecipeCategoryID { get; set; }
        public virtual RecipeCategory RecipeCategory { get; set; }
    }
}
