using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.TemperatureFacade
{
    public class LocalTemperature
    {
        public double Celcius { get; set; }
        public double Farenheit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
