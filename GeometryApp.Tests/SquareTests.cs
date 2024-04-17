using Xunit;
using GeometryLibrary;

namespace GeometryApp.Tests
{
    public class SquareTests
    {
        [Fact]
        public void TestSquareArea()
        {
            // Arrange
            double sideLength = 5;
            Square square = new Square(sideLength);

            // Act
            double area = square.CalculateArea();

            // Assert
            Assert.Equal(25, area);
        }

        [Fact]
        public void TestSquarePerimeter()
        {
            // Arrange
            double sideLength = 5;
            Square square = new Square(sideLength);

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.Equal(20, perimeter);
        }
    }
}
