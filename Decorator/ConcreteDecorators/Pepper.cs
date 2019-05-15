using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorators
{
    public class Pepper: PizzaDecorator
    {
        public Pepper(Pizza pizza)
            :base(pizza)
        {
            Description = "Pepper";
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
    }
}
