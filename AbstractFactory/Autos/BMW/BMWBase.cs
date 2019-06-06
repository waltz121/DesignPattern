using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Autos.BMW
{
    public abstract class BMWBase : IAutomobile
    {
        public abstract string Name { get; }
        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is on and running.");
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is off.");
        }
    }
}
