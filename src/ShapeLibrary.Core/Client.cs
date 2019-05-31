using ShapeLibrary.Core.Abstractions;
using ShapeLibrary.Core.Shapes;

namespace ShapeLibrary.Core
{
    public class Client : IClient
    {
        public double CalculateCircleArea(double radius)
        {
            var circle = new Circle(radius);
            return CalculateShapeArea(circle);
        }

        public double CalculateTriangleArea(double aSide, double bSide, double cSide)
        {
            var triangle = new Triangle(aSide, bSide, cSide);
            return CalculateShapeArea(triangle);
        }

        public double CalculateShapeArea(IShape shape) => shape.CalculateArea();

        public bool IsRightTriangle(double aSide, double bSide, double cSide)
        {
            var triangle = new Triangle(aSide, bSide, cSide);
            return triangle.IsRightAngle;
        }
    }
}
