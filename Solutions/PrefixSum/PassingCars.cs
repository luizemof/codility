using System;
namespace Codility.Solutions.PrefixSum
{
    // https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
    public class PassingCars
    {
        public int Solution(int[] A)
        {
            int N = A.Length;
            int[] prefixSum = new int[N];
            prefixSum[0] = A[0];
            for (int i = 1; i < N; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i];
            }

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == 0)
                {
                    count += prefixSum[N - 1] - prefixSum[i];
                }

                if (count > 1000000000)
                    return -1;
            }

            return count;
        }
    }
}