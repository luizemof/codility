using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.PrefixSum
{
    public static class MinAvgTwoSlice
    {
        public static int Solution(int[] A)
        {
            int[] prefixSum = PrefixSum(A);
            int prefixSumSize = prefixSum.Length;
            int result = 0;
            decimal minValue = decimal.MaxValue;
            decimal avg1;
            decimal avg2;
            for (int i = 0; i < prefixSumSize - 1; i++)
            {
                avg1 = (prefixSum[i + 1] - prefixSum[i] + A[i]) / 2M;
                if(avg1 < minValue )
                {
                    result = i;
                    minValue = avg1;
                }

                if(i + 2 < prefixSumSize)
                {
                    avg2 = (prefixSum[i + 2] - prefixSum[i] + A[i]) / 3M;
                    if(avg2 < minValue)
                    {
                        result = i;
                        minValue = avg2;
                    }
                }
            }

            return result;
        }

        private static int[] PrefixSum(int[] A)
        {
            var prefixSum = new int[A.Length];
            prefixSum[0] = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i];
            }

            return prefixSum;
        }
    }
}
