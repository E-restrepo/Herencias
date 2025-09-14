using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rhombus : GeometricFigure
    {
        private double d1, d2, side;
        public Rhombus(string name, double d1, double d2, double side) : base(name)
        { this.d1 = d1; this.d2 = d2; this.side = side; }

        public override double GetArea() => (d1 * d2) / 2;
        public override double GetPerimeter() => 4 * side;
    }
}
