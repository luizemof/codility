using Codility.Solutions.MaximumSliceProblem;
using NUnit.Framework;

namespace Solutions.Tests.MaximumSliceProblem
{
    [TestFixture]
    public class MaxDoubleSliceSumTests
    {
        [TestCase]
        public void Basic()
        {
            // Arrange
            int[] A = new int[] { 3, 2, 6, -1, 4, 5, -1, 2 };
            int expected = 17;
           
            // Act
            int result = new MaxDoubleSliceSum().Solution(A);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}