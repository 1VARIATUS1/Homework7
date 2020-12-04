using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public class Satellite:Object
    {
        public Satellite(string name, uint size, float mass, float gravity, int temperature)
        {
            Name = name;
            Size = size;
            Mass = mass;
            Gravity = gravity;
            Temperature = temperature;
        }
    }
}

