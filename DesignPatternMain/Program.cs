using Decorator.Component;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;
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
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Pepper(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }
    }
}
