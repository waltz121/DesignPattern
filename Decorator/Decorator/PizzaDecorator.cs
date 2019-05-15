﻿using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return _pizza.Description;
        }
    }
}
