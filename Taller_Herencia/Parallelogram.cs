using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallelogram : GeometricFigure
    {
        private double a, b, h;
        public Parallelogram(string name, double a, double b, double h) : base(name) { this.a = a; this.b = b; this.h = h; }

        public override double GetArea() => b * h;
        public override double GetPerimeter() => 2 * (a + b);
    }
}
