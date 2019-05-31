using System;
using System.Linq;
using ShapeLibrary.Core.Abstractions;

namespace ShapeLibrary.Core.Shapes
{
    public class Triangle : IShape
    {
        private readonly double _aSide;
        private readonly double _bSide;
        private readonly double _cSide;
        private readonly double _p;

        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0)
            {
                throw new ArgumentException("Side of triangle must be positive value", nameof(aSide));
            }

            if (bSide <= 0)
            {
                throw new ArgumentException("Side of triangle must be positive value", nameof(bSide));
            }

            if (cSide <= 0)
            {
                throw new ArgumentException("Side of triangle must be positive value", nameof(cSide));
            }

            if ((aSide + bSide > cSide && bSide + cSide > aSide && cSide + aSide > bSide) == false)
            {
                throw new InvalidOperationException("Cannot create triangle with given arguments");
            }

            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
            _p = (aSide + bSide + cSide) / 2;
        }

        public bool IsRightAngle => HasRightAngle();

        public double CalculateArea() => Math.Sqrt(_p * (_p - _aSide) * (_p - _bSide) * (_p - _cSide));

        private bool HasRightAngle() => HasRightAngle(_aSide, _bSide, _cSide);

        private static bool HasRightAngle(params double[] numbers)
        {
            double accumulator = 0;

            double max = numbers.Aggregate((a, b) =>
            {
                if (a > b)
                {
                    accumulator += b * b;
                    return a;
                }

                accumulator += a * a;
                return b;
            });

            return Math.Abs(accumulator - max * max) < double.Epsilon;
        }
    }
}
