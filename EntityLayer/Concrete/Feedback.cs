using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int NameSurname { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
        public int Image { get; set; }
    }
}
