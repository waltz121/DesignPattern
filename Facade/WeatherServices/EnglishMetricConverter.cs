using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherServices
{
    public class EnglishMetricConverter
    {
        public double FarenheitToCelcious(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}
