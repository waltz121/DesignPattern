using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Autos;
using AbstractFactory.Autos.BMW;

namespace AbstractFactory.Factory
{
    public class BMWFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            return new BMWM3();
        }

        public IAutomobile CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public IAutomobile CreateEconomyCar()
        {
            return new BMW328i();
        }
    }
}
