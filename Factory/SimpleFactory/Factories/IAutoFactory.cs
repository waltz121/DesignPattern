using Factory.SimpleFactory.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.SimpleFactory.Factories
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}
