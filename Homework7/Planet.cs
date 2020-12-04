using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public class Planet:Object
    {
        public PlanetType PlanetType { get; set; }
        public Satellite Satellite { get; set; }

        public Planet(string name, uint size, double mass, double gravity, int temperature)
        {
            Name = name;
            Size = size;
            Mass = mass;
            Gravity = gravity;
            Temperature = temperature;
        }
    }
}
