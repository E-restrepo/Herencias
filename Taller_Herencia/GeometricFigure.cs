using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    
        public override string ToString()
        {
            return $"{Name,-18} => Area.....: {GetArea():0.00000}\tPerimeter: {GetPerimeter():0.00000}";
        }
    }
}
