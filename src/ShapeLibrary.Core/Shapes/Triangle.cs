using System;
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

            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
            _p = (aSide + bSide + cSide) / 2;
        }

        public double CalculateArea() => Math.Sqrt(_p * (_p - _aSide) * (_p - _bSide) * (_p - _cSide));
    }
}
