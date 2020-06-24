using Codility.Solutions.PrimeAndCompositeNumbers;
using NUnit.Framework;

namespace Solutions.Tests.PrimeAndCompositeNumbers
{
    [TestFixture]
    public class CountFactorsTests
    {
        [TestCase]
        public void Basic()
        {
            // Arrange
            int n = 24;
            int expected = 8;
            CountFactors solution = new CountFactors();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void LargestValuePrime()
        {
            // Arrange
            int n = int.MaxValue;
            int expected = 2;
            CountFactors solution = new CountFactors();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void LargestValue()
        {
            // Arrange
            int n = int.MaxValue - 1;
            int expected = 192;
            CountFactors solution = new CountFactors();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void QuadraticValue()
        {
            // Arrange
            int n = 9;
            int expected = 3;
            CountFactors solution = new CountFactors();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void QuadraticValueWithMoreThanThree()
        {
            // Arrange
            int n = 81;
            int expected = 5;
            CountFactors solution = new CountFactors();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void MinValue()
        {
            // Arrange
            int n = 1;
            int expected = 1;
            CountFactors solution = new CountFactors();

            // Act
            int result = solution.Solution(n);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}