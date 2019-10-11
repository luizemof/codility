using NUnit.Framework;
using Solutions.SOTI.Test;

namespace Tests
{
    [TestFixture]
    public class SOTIDemoTest
    {
        [TestCase(new int[] { 1, 3, 6, 4, 1, 2 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 4)]
        [TestCase(new int[] { -1, -3 }, ExpectedResult = 1)]
        public int Basic(int[] A)
        {
            return new SOTIDemoTask().Solution(A);
        }
    }
}