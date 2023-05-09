using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public int CommentNumber { get; set; }
        public int BlogCategoryID { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }  
        public List<Comment> Comments { get; set; }
    }
}
