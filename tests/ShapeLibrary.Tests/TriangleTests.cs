using System;
using ShapeLibrary.Core.Shapes;
using Xunit;

namespace ShapeLibrary.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 4, -0.512)]
        [InlineData(0, 0, 0)]
        public void InstantiationFailedTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(12, 7, 26)]
        public void NotTriangleTest(double a, double b, double c)
        {
            Assert.Throws<InvalidOperationException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(12, 5, 9, 20.396078)]
        [InlineData(4.095, 13.772, 15.154, 27.594879)]
        public void CalculateAreaTest(double a, double b, double c, double result)
        {
            var triangle = new Triangle(a, b, c);

            double actual = triangle.CalculateArea();

            Assert.Equal(result, actual, 6);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(3, 6, 5, false)]
        public void HasRightAngleTest(double a, double b, double c, bool result)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(result, triangle.IsRightAngle);
        }
    }
}
