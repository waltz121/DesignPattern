using Factory.SimpleFactory.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.SimpleFactory.Factories
{
    public class BMWFactory: IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMW("BMW M5 Cabriolet");
        }
    }
}
