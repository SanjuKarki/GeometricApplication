using Xunit;
using GeometryLibrary;

namespace GeometryApp.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TestTriangleArea()
        {
            // Arrange
            double baseLength = 3; // Assuming base is side1
            double height = 4; // Assuming height is side2
            Triangle triangle = new Triangle(baseLength, height);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area); // Area = 0.5 * base * height = 0.5 * 3 * 4 = 6
        }

        // Other test methods for perimeter and other scenarios
    }
}
