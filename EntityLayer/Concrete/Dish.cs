using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Dish
    {
        public int DishID { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
