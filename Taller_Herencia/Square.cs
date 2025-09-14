using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double a;
        public Square(string name, double a) : base(name) { this.a = a; }

        public override double GetArea() => a * a;
        public override double GetPerimeter() => 4 * a;
    }
}
