namespace ShapeLibrary.Core.Abstractions
{
    public interface IClient
    {
        double CalculateCircleArea(double radius);

        double CalculateTriangleArea(double aSide, double bSide, double cSide);

        double CalculateShapeArea(IShape shape);

        bool IsRightTriangle(double aSide, double bSide, double cSide);
    }
}
