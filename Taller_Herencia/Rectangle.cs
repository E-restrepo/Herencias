using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle : GeometricFigure
    {
        private double a, b;
        public Rectangle(string name, double a, double b) : base(name) { this.a = a; this.b = b; }

        public override double GetArea() => a * b;
        public override double GetPerimeter() => 2 * (a + b);
    }
}
