namespace Geometry
{
    internal class main
    {
        static void Main(string[] args)
        {
            var circle = new Geometry.Circle(nameof(Geometry.Circle), 5);
            var square = new Geometry.Square(nameof(Geometry.Square), 10);
            var rhombus = new Geometry.Rhombus(nameof(Geometry.Rhombus), 7, 10, 5);
            var kite = new Geometry.Kite(nameof(Geometry.Kite),  6, 5, 7, 8);
            var rectangle = new Geometry.Rectangle(nameof(Geometry.Rectangle), 4.568, 67.790);
            var parallelogram = new Geometry.Parallelogram(nameof(Geometry.Parallelogram), 14.65, 54.67, 23.09);
            var triangle = new Geometry.Triangle(nameof(Geometry.Triangle), 45.56, 12.34, 27.09, 15) ;
            var trapeze = new Geometry.Trapeze(nameof(Geometry.Trapeze), 10, 20, 30, 40, 20);

            var figures = new List<Geometry.GeometricFigure> { circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }
        }
    }
}
