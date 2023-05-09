using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
