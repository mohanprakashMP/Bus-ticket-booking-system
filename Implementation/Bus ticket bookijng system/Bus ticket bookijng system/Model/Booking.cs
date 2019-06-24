using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_ticket_bookijng_system.Model
{
   public  class Booking     
        
    {
        public string id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public int  ticket { get; set; }
        public string price { get; set; }
        public DateTime date { get; set; }
        public int customerid { get; set; }
    }
}
