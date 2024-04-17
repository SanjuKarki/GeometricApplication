using System;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private readonly double baseLength;
        private readonly double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }

        public double CalculatePerimeter()
        {
            // Assuming it's an equilateral triangle for simplicity
            return 3 * baseLength;
        }
    }
}
