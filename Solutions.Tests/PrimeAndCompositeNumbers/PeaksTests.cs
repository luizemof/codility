using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Solutions.PrimeAndCompositeNumbers;

namespace Solutions.Tests.PrimeAndCompositeNumbers
{
    [TestClass]
    public class PeaksTests
    {

        [TestMethod]
        public void Basic()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            int expected = 3;
            Peaks solution = new Peaks();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WithPrimeNumber()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2, 4 };
            int expected = 1;
            Peaks solution = new Peaks();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WithoutPeek()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int expected = 0;
            Peaks solution = new Peaks();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WithSingleElement()
        {
            // Arrange
            int[] A = new int[] { 1 };
            int expected = 0;
            Peaks solution = new Peaks();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WithZeros()
        {
            // Arrange
            int[] A = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int expected = 0;
            Peaks solution = new Peaks();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}