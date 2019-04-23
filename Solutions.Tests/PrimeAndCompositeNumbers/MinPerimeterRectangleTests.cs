using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Solutions.PrimeAndCompositeNumbers;

namespace Solutions.Tests.PrimeAndCompositeNumbers
{
    [TestClass]
    public class MinPerimeterRectangleTests
    {
        [TestMethod]
        public void Basic()
        {
            // Arrange
            int n = 30;
            int expected = 22;
            MinPerimeterRectangle solution = new MinPerimeterRectangle();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Quadratic()
        {
            // Arrange
            int n = 9;
            int expected = 12;
            MinPerimeterRectangle solution = new MinPerimeterRectangle();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LargestValue()
        {
            // Arrange
            int n = 1000000000;
            int expected = 126500;
            MinPerimeterRectangle solution = new MinPerimeterRectangle();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinValue()
        {
            // Arrange
            int n = 1;
            int expected = 4;
            MinPerimeterRectangle solution = new MinPerimeterRectangle();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}