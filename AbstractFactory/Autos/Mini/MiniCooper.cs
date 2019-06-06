﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Autos.Mini
{
    public class MiniCooper : IAutomobile
    {
        string name;

        public MiniCooper()
        {
            name = "Mini Cooper";
        }

        public void AddSportPackage()
        {
            name += " S";
        }

        public void AddLuxuryPackage()
        {
            name += " with leather upholstery";
        }

        public void TurnOn()
        {
            Console.WriteLine("The " + name + " is on! 1.6 Liters of brutal force is churning.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The Mini Cooper is has turned off.");
        }
    }
}
