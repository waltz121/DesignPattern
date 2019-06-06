using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Autos;
using AbstractFactory.Autos.Mini;

namespace AbstractFactory.Factory
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAutomobile CreateSportsCar()
        {
            var mini = new MiniCooper();

            mini.AddSportPackage();

            return mini;
        }

        public IAutomobile CreateLuxuryCar()
        {
            var mini = new MiniCooper();

            mini.AddLuxuryPackage();

            return mini;
        }

        public IAutomobile CreateEconomyCar()
        {
            return new MiniCooper();
        }
    }
}
