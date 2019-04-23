using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Solutions.PrimeAndCompositeNumbers;

namespace Solutions.Tests.PrimeAndCompositeNumbers
{
    [TestClass]
    public class FlagsTests
    {
        [TestMethod]
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
    }
}