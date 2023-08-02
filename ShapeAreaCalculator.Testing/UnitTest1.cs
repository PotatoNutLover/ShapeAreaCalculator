using ShapeAreaCalculator;
using ShapeAreaCalculator.Shapes;
using ShapeAreaCalculator.Validators;

namespace ShapeAreaCalculator.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateValidCircleArea()
        {
            // Arrange
            Shape circle = new Circle("circ", 5);
            double area;
            // Act
            area = circle.CalculateArea();
            //Assert
            Assert.Equal(78.54, Math.Round(area, 2));
        }

        [Fact]
        public void CalculateInvalidCircleArea()
        {
            // Arrange
            Shape circle = new Circle("Some forbidden name", 5);
            double area;
            //Act&Assert
            Assert.Throws<Exception>(() => area = circle.CalculateArea());
        }

        [Fact]
        public void CreateInvalidCircle()
        {
            //Arrange&Act&Assert
            Assert.Throws<ArgumentException>(() => new Circle("circ", -54));
        }

        [Fact]
        public void CalculateValidTriangleArea()
        {
            // Arrange
            Shape triangle = new Triangle("triangle", 10, 9, 8);
            
            double area;
            // Act
            area = triangle.CalculateArea();
            //Assert
            Assert.Equal(34.20, Math.Round(area, 2));
        }

        [Fact]
        public void CalculateInvalidTriangleArea()
        {
            // Arrange
            Shape triangle = new Triangle("Some forbidden name", 10,8,10);
            double area;
            //Act&Assert
            Assert.Throws<Exception>(() => area = triangle.CalculateArea());
        }

    }
}