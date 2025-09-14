using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Kite : GeometricFigure
    {
        private double d1, d2, a, b;
        public Kite(string name, double d1, double d2, double a, double b) : base(name)
        { this.d1 = d1; this.d2 = d2; this.a = a; this.b = b; }

        public override double GetArea() => (d1 * d2) / 2;
        public override double GetPerimeter() => 2 * (a + b);
    }
}
