using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(100, 200, 300)]
        [TestCase(-10, 5, -5)]
        [TestCase(0, 25, 25)]
        public void Addition_ShouldReturnExpectedResult(double a, double b, double expected)
        {
            // Arrange & Act
            double actual = calculator.Addition(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}