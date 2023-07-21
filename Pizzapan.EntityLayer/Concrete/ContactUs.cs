
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class ContactUs
    {
        public int ContactUsID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string StartEndDate { get; set; }
    }
}
