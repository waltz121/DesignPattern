using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.SimpleFactory.Autos
{
    public class MiniCooper: IAuto
    {
        public string Name
        {
            get; private set;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is up and running with a mighty roar.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is turned off.");
        }
    }
}
