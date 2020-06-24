using Codility.Solutions.MaximumSliceProblem;
using NUnit.Framework;

namespace Solutions.Tests.MaximumSliceProblem
{
    [TestFixture]
    public class MaxSliceTests
    {
        [TestCase]
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

        [TestCase]
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


        [TestCase]
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
