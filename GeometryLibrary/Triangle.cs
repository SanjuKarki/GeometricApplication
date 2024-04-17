namespace GeometryLibrary
{
    public class Triangle
    {
        private double baseLength;
        private double height;

        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

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
            return Side1 + Side2 + Side3;
        }
    }
}
