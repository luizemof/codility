using System;

namespace Codility.Solutions.MaximumSliceProblem
{

    // https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_double_slice_sum/
    public class MaxDoubleSliceSum
    {
        public int Solution(int[] A)
        {
            int N = A.Length;
            int[] startAt = new int[N];
            int[] endAt = new int[N];
            int doubleSlice = 0;

            for (int i = 1; i < N; i++)
            {
                endAt[i] = Math.Max(0, endAt[i - 1] + A[i]);
            }

            for (int i = N - 2; i > 0; i--)
            {
                startAt[i] = Math.Max(0, startAt[i + 1] + A[i]);
            }

            for (int i = 1; i < N - 1; i++)
            {
                doubleSlice = Math.Max(doubleSlice, startAt[i + 1] + endAt[i - 1]);
            }


            return doubleSlice;
        }
    }
}