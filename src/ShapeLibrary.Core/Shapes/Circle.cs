﻿using System;
using ShapeLibrary.Core.Abstractions;

namespace ShapeLibrary.Core.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive value", nameof(radius));
            }

            _radius = radius;
        }

        public double CalculateArea() => Math.PI * _radius * _radius;
    }
}
