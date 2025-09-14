using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapeze : GeometricFigure
    {
        private double a, b, c, d, h;
        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name)
        { this.a = a; this.b = b; this.c = c; this.d = d; this.h = h; }

        public override double GetArea() => ((b + d) * h/2);
        public override double GetPerimeter() => a + b + c + d;
    }
}
