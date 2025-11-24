using Xunit;
using MyApp;

namespace MyApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.Subtract(5, 2);

            // Assert
            Assert.Equal(3, result);
        }
    }
}