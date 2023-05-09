using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactInfo
    {
        public int ContactInfoID { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string AvailableTime { get; set; }
        public string Mail { get; set; }
        public string Map { get; set; }
        
    }
}
