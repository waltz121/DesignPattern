using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Model
{
    public class Order
    {
        public string ShippingMethod { get; set; }
        public string Destination { get; set; }
        public string Origin { get; set; }
    }
}
