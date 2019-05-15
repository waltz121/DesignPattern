﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WeatherServices
{
    public class GeoLookupService
    {
        public Coordinates GetCoordinatesForZipCode(string zipCode)
        {
            return new Coordinates()
            {
                Latitude = 43.676422,
                Longitude = -116.278025
            };
        }

        public class Coordinates
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Boise";
        }

        public string GetStateForZipCode(string zipCode)
        {
            return "Idaho";
        }
    }
}
