using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogCategory
    {
        public int BlogCategoryID { get; set; }
        public string BlogCategoryName { get; set; }
        public List<Blog> Blogs { get; set; }
       
    }
}
