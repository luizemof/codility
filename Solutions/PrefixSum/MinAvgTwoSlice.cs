using System;
namespace Codility.Solutions.PrefixSum
{
    // https://app.codility.com/programmers/lessons/5-prefix_sums/min_avg_two_slice/
    public class MinAvgTwoSlice
    {
        public int Solution(int[] A)
        {
            int N = A.Length;
            int[] sum = new int[N];
            int minValue = int.MaxValue;
            int tempValue = 0;
            int result;

            sum[0] = A[0];
            for (int i = 1; i < N; i++)
            {
                sum[i] = sum[i - 1] + A[i];
            }

            minValue = sum[1] / 2;
            result = 0;
            for(int i = 1; i < N - 1; i++)
            {
                tempValue = (int)(sum[i + 1] - sum[i - 1]) / 2;
                if(tempValue < minValue)
                {
                    minValue = tempValue;
                    result = i;
                }
            }

            return result;
        }
    }
}