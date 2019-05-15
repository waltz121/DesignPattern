using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Model;

namespace Strategy.Strategy
{
    class UPSShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 4.25;
        }
    }
}
