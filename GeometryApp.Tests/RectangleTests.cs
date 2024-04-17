using Xunit;
using GeometryLibrary;

namespace GeometryApp.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void TestRectangleArea()
        {
            // Arrange
            double length = 5;
            double width = 3;
            Rectangle rectangle = new Rectangle(length, width);

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            Assert.Equal(15, area);
        }

        [Fact]
        public void TestRectanglePerimeter()
        {
            // Arrange
            double length = 5;
            double width = 3;
            Rectangle rectangle = new Rectangle(length, width);

            // Act
            double perimeter = rectangle.CalculatePerimeter();

            // Assert
            Assert.Equal(16, perimeter);
        }
    }
}
