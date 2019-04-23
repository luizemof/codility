using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Solutions.MaximumSliceProblem;

namespace Solutions.Tests.MaximumSliceProblem
{
    [TestClass]
    public class MaxSliceTests
    {
        [TestMethod]
        public void Basic()
        {
            // Arrange
            int expected = 5;
            int[] input = new int[] { 3, 2, -6, 4, 0 };
            MaxSliceSum act = new MaxSliceSum();

            // Act
            int result = act.Solution(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OneNegativeElement()
        {
            // Arrange
            int expected = -10;
            int[] input = new int[] { -10 };
            MaxSliceSum act = new MaxSliceSum();

            // Act
            int result = act.Solution(input);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AllNegativeProgressive()
        {
            // Arrange
            int expected = -6;
            int[] input = new int[] { -10, -9, -8, -7, -6 };
            MaxSliceSum act = new MaxSliceSum();

            // Act
            int result = act.Solution(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
