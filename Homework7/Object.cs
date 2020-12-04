using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    public class Object
    {
        public string Name { get; set; }
        public uint Size { get; set; }
        public double Mass { get; set; }
        public double Gravity { get; set; }
        public int Temperature { get; set; }
        public Movement Movement { get; set; }
        public ChemicalComposition ChemicalComposition { get; set; }
    }
}
