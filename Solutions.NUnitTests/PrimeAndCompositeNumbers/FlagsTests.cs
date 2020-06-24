using Codility.Solutions.PrimeAndCompositeNumbers;
using NUnit.Framework;
using System;

namespace Solutions.Tests.PrimeAndCompositeNumbers
{
    [TestFixture]
    public class FlagsTests
    {
        [TestCase]
        public void Basic()
        {
            // Arrange
            int[] A = new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            int expected = 3;
            Flags solution = new Flags();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void WithoutPeek()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int expected = 0;
            Flags solution = new Flags();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void WithoutPeekSameValues()
        {
            // Arrange
            int[] A = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int expected = 0;
            Flags solution = new Flags();

            // Act
            int result = solution.Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}