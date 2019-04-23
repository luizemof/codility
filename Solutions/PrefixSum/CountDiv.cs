using System;
namespace Codility.Solutions.PrefixSum
{
    public class CountDiv
    {
        public int Solution(int A, int B, int K)
        {
            if (B == 0)
                return 1;

            if (K > B)
                return 0;

            if (A == B)
                return (A % K) == 0 ? 1 : 0;

            int countZero = A == 0 ? 1 : 0;
            int a1 = A < K ? K : A + (A % K);
            int an = B - (B % K);
            return ((an - a1) / K) + 1 + countZero;
        }
    }
}