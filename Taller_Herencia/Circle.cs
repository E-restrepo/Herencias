using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double r;
        public Circle(string name, double r) : base(name) { this.r = r; }

        public override double GetArea() => Math.PI * r * r;
        public override double GetPerimeter() => 2 * Math.PI * r;
    }
}
