using Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ShippingCostCalculatorService
    {

        readonly IShippingCostStrategy shippingCostStrategy;
        public ShippingCostCalculatorService(IShippingCostStrategy shippingCostStrategy)
        {
            this.shippingCostStrategy = shippingCostStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return shippingCostStrategy.Calculate(order);
        }
    }
}
