using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_ticket_bookijng_system.Model
{
   public class Bus
    { public int id { get; set; }
        public string number { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string route { get; set; }
    }
}
