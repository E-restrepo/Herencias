using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : GeometricFigure
    {
        private double a, b, c, h;
        public Triangle(string name, double a,  double b, double c, double h ) : base(name)
        {
            this.a = a; this.h = h; this.b = b; this.c = c;
        }

        public override double GetArea() => (b * h) / 2;
        public override double GetPerimeter() => a + b + c;
    }
}
