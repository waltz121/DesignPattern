using Decorator.Component;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;
using Strategy;
using Strategy.Model;
using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //executeDecorator();
            executeStrategy();
        }

        static void executeDecorator()
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Pepper(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }

        static void executeStrategy()
        {
            var strategy = new FedExShippingCostStrategy();
            ShippingCostCalculatorService shippingCostCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = new Order()
            {
                ShippingMethod = "FedEx",
                Destination = "1234 Desmesa St. Makati City philippines",
                Origin = "123 Linoln St. America"
            };

            var cost = shippingCostCalculatorService.CalculateShippingCost(order);

            Console.WriteLine("Shipping Method: " + order.ShippingMethod);
            Console.WriteLine("Destination: " + order.Destination);
            Console.WriteLine("Origin: " + order.Origin);

            Console.WriteLine("Cost: " + cost);
            Console.ReadKey();
        }
    }
}
