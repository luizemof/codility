using NUnit.Framework;
using Solutions.NetCore.PrefixSum;

namespace Solutions.NUnitTests.PrefixSum
{
    [TestFixture]
    public class MinAvgTwoSliceTest
    {
        [TestCase(new int[] { 4, 2, 2, 5, 1, 5, 8 }, ExpectedResult = 1)]
        public int MinAvgTwoSliceTestBasic(int [] A)
        {
            return MinAvgTwoSlice.Solution(A);
        }
    }
}
