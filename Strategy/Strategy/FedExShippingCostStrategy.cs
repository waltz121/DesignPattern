using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Model;

namespace Strategy.Strategy
{
    public class FedExShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 5.00;
        }
    }
}
